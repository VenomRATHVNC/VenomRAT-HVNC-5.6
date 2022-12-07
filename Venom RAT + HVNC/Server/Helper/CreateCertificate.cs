using System;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace Server.Helper
{
	// Token: 0x02000042 RID: 66
	public static class CreateCertificate
	{
		// Token: 0x06000296 RID: 662 RVA: 0x000205D8 File Offset: 0x0001E7D8
		public static X509Certificate2 CreateCertificateAuthority(string caName, int keyStrength)
		{
			SecureRandom secureRandom = new SecureRandom();
			RsaKeyPairGenerator rsaKeyPairGenerator = new RsaKeyPairGenerator();
			rsaKeyPairGenerator.Init(new KeyGenerationParameters(secureRandom, keyStrength));
			AsymmetricCipherKeyPair asymmetricCipherKeyPair = rsaKeyPairGenerator.GenerateKeyPair();
			X509V3CertificateGenerator x509V3CertificateGenerator = new X509V3CertificateGenerator();
			X509Name issuerDN = new X509Name("CN=" + caName + ",OU=Venom,O=VenomRAT By Venom,L=SH,C=CN");
			X509Name subjectDN = new X509Name("CN=VenomRAT");
			BigInteger serialNumber = BigInteger.ProbablePrime(160, new SecureRandom());
			x509V3CertificateGenerator.SetSerialNumber(serialNumber);
			x509V3CertificateGenerator.SetSubjectDN(subjectDN);
			x509V3CertificateGenerator.SetIssuerDN(issuerDN);
			x509V3CertificateGenerator.SetNotAfter(DateTime.UtcNow.Subtract(new TimeSpan(-3650, 0, 0, 0)));
			x509V3CertificateGenerator.SetNotBefore(DateTime.UtcNow.Subtract(new TimeSpan(285, 0, 0, 0)));
			x509V3CertificateGenerator.SetPublicKey(asymmetricCipherKeyPair.Public);
			x509V3CertificateGenerator.AddExtension(X509Extensions.SubjectKeyIdentifier, false, new SubjectKeyIdentifierStructure(asymmetricCipherKeyPair.Public));
			x509V3CertificateGenerator.AddExtension(X509Extensions.BasicConstraints, true, new BasicConstraints(true));
			ISignatureFactory signatureFactory = new Asn1SignatureFactory("SHA512WITHRSA", asymmetricCipherKeyPair.Private, secureRandom);
			return new X509Certificate2(DotNetUtilities.ToX509Certificate(x509V3CertificateGenerator.Generate(signatureFactory)))
			{
				PrivateKey = DotNetUtilities.ToRSA(asymmetricCipherKeyPair.Private as RsaPrivateCrtKeyParameters)
			};
		}
	}
}
