

  
# CodeThreat - SAST Benchmark Tool for Web Application Security
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://codethreat.com">
    <img src="https://www.codethreat.com/_next/static/media/ct-logo.0cc6530f.svg" alt="Logo" width="259" height="39">
  </a>

  <h3 align="center">IssueBlot.NET</h3>

</p>


## CodeThreat - SAST Benchmark

IssueBlot.Net is a purposely vulnerable C# application, designed for benchmarking Static Application Security Testing (SAST) tools. This project is inspired by similar projects like WebGoat.NET, and it aims to provide a platform for security enthusiasts and developers to learn about and test the capabilities of various SAST tools.

While there are other vulnerable applications like OWASP Benchmark, Juiceshop, DVWA that contain a variety of vulnerabilities, IssueBlot.Net offers a unique set of challenges focused solely on C# codebase. By providing a comprehensive set of C# specific vulnerabilities, we aim to help security enthusiasts and developers test and improve the effectiveness of their SAST tools.

## Usage

Use IssueBlot.Net to benchmark the effectiveness of SAST tools. Please note that this application is intentionally vulnerable and should not be deployed in any sensitive or production environment.

Here are some example vulnerabilities found in the project:

### CoreStandaloneBlot

-   Command Injection in `Bulk/CommandInjection1.cs`:  allows an attacker to execute arbitrary commands on the server through user-controlled input.
-   Directory Traversal in `Bulk/DirectoryTraversal1.cs`:  permits an attacker to access files outside the intended directory structure.
-   SQL Injection in `Bulk/SQLInjection1.cs`:  occurs when user-supplied input is not properly validated or sanitized, leading to unauthorized database queries.
-   Insecure Password-Based Encryption (PBE) Work Factor in `Cryptography/InsecurePBEWorkFactor1.cs`:  weakens the encryption strength by using an inadequate work factor for password-based encryption.
-   Deserialization Vulnerability using BinaryFormatter in `Deserialization/BinaryFormatterDS.cs`:  arises when untrusted data is deserialized, potentially leading to remote code execution or other attacks.

### NETMVCBlot

-   Command Injection in `Controllers/CodeInjectionController.cs`:  allows an attacker to execute arbitrary commands on the server through user-controlled input.
-   SQL Injection in `Controllers/SQLInjController.cs`:  occurs when user-supplied input is not properly validated or sanitized, leading to unauthorized database queries.
-   Server-Side Request Forgery (SSRF) in `Controllers/SSRFController.cs`:  enables an attacker to make unauthorized requests to internal network resources.

### NETStandaloneBlot

-   Basic Authentication Vulnerability in `Authentication/BasicAuthentication1.cs`: allows authentication credentials to be transmitted without proper encryption or protection.
-   Insecure Cryptographic Practices in `Cryptography/CustomSSLValidation1.cs`:  arises from insecure usage of cryptographic functions, weakening the overall security.
-   Deserialization Vulnerability using FastJson in `Deserialization/FastJsonDeserialization.cs`:  occurs when untrusted data is deserialized using the FastJson library, potentially leading to remote code execution or other attacks.
-   Code Injection in `Injection/CodeInjection.cs`:  allows an attacker to inject and execute arbitrary code within the application context.
-   XML External Entity (XXE) Injection in `Other/XXE1.cs`:  allows the parsing of XML input with external entities, leading to potential data disclosure or denial-of-service attacks.


### NETWebFormsBlot

-   Client-Side Code Injection in `ClientSideCodeInj.aspx.cs`:  enables an attacker to inject and execute arbitrary code on the client-side.
-   Insecure File Upload in `HttpFileCase.aspx.cs`:  allows an attacker to upload malicious files, potentially leading to remote code execution or unauthorized access.
-   Parameter Overloading in `ParameterOverloading.aspx.cs`: occurs when multiple methods with the same name but different parameter lists are defined, potentially leading to confusion or unexpected behavior.

Please note that this project may have additional vulnerabilities beyond the ones listed here. The purpose of this benchmark project is to demonstrate and raise awareness about common web application vulnerabilities.

## Frameworks Used in the Project

The benchmark project "Issublot" utilizes several popular web application frameworks for development. These frameworks provide a foundation for building robust and scalable web applications. The frameworks used in this project include:

1.  ASP.NET Core MVC:
2.  ASP.NET Web Forms
3.  ASP.NET Web API
4.  WCF (Windows Communication Foundation)
## Contributing

We welcome contributions to IssueBlot.Net. If you have found a bug, want to suggest a feature, or want to propose a vulnerability scenario, please open an issue.

For code contributions, please fork the repository, make your changes, and submit a pull request.

## Disclaimer

IssueBlot.Net is intentionally vulnerable for educational purposes. We disclaim any liability for misuse of this software.

## Contact

For any questions or discussions, please open an issue on this repository, and we'll get back to you as soon as possible.

  
<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[forks-shield]: https://img.shields.io/github/forks/CodeThreat/IssueBlot.NET.svg?style=flat-square
[forks-url]: https://github.com/CodeThreat/IssueBlot.NET/network/members
[stars-shield]: https://img.shields.io/github/stars/CodeThreat/IssueBlot.NET.svg?style=flat-square
[stars-url]: https://github.com/CodeThreat/IssueBlot.NET/stargazers
[issues-shield]: https://img.shields.io/github/issues/CodeThreat/IssueBlot.NET.svg?style=flat-square
[issues-url]: https://github.com/othneildrew/IssueBlot.NET/issues
[license-shield]: https://img.shields.io/github/license/CodeThreat/IssueBlot.NET.svg?style=flat-square
[license-url]: https://github.com/CodeThreat/IssueBlot.NET/blob/main/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/codethreat
