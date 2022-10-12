# Spoleto.Cryptography.RSA

The helper for creating X509 certificates from a body and a private key in PEM format for .NET Core 3.1.  
Methods are also available: Sign, Verify data based on PEM.

## Examples:
```
// Create certificate from the body and the private key in PEM format:
var certificate = RSACryptoPemHelper.CreateCertificate(certificatePemText, privateKeyPemText);

var data = "The string to sign";

// Sign data by the private key:
var signedData = RSACryptoPemHelper.Sign(privateKeyPemText, data);

// Verify signed data by the public key in the certificate:
var isVerified = RSACryptoPemHelper.Verify(certificatePemText, data, signedData);
```

## Unit tests
You can find the unit tests here:  
https://github.com/spoleto-software/Spoleto.Cryptography.RSA/tree/main/src/Spoleto.Cryptography.Rsa.Tests
