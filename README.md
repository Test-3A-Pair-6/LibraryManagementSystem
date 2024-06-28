# Capstone Project: API Testing with Postman CLI and Newman in GitHub Actions

## Overview

This repository contains the configuration and scripts for running API tests using Postman CLI and Newman within GitHub Actions. As part of my capstone project, I aimed to integrate automated API testing into the CI/CD pipeline, showcasing the capabilities of Postman CLI and Newman. I forked the main development repo to ensure topic integrity.

## Project Details

### Project Name

Capstone Project: Automated API Testing

### Author

Miray Sönmez

## Description

This project demonstrates how to set up and run automated API tests using Postman CLI and Newman in a continuous integration (CI) pipeline via GitHub Actions. The tests are configured to run against API endpoints to ensure their functionality and reliability.

### Objectives

- Integrate Postman CLI and Newman for automated API testing.
- Configure GitHub Actions to run the tests as part of the CI pipeline.
- Demonstrate the process and configuration through a well-documented README.

## Tools and Technologies

- **Postman CLI**: Command-line tool to interact with Postman APIs.
- **Newman**: Command-line collection runner for Postman.
- **GitHub Actions**: CI/CD platform for automating workflows.
- **Node.js**: JavaScript runtime for executing Newman.

## GitHub Actions Workflow

### YAML Configuration

The GitHub Actions workflow is defined in the `.github/workflows/newman.yml` file. Below is the configuration:

```
yaml
Copy code
name: Run Newman Tests

on: [push, pull_request]

jobs:
  newman-test:
    runs-on: ubuntu-latest

    steps:
    - name: Checkout repository
      uses: actions/checkout@v2

    - name: Set up Node.js
      uses: actions/setup-node@v2
      with:
        node-version: '14'

    - name: Install Newman
      run: npm install -g newman

    - name: Run Newman tests
      run: |
        newman run ./postman/WebAPI.postman_collection.json -e ./postman/LibraryEnv.postman_environment.json --insecure

```

### Explanation

- **Checkout Repository**: Checks out the repository to the runner.
- **Set up Node.js**: Sets up the Node.js environment required to run Newman.
- **Install Newman**: Installs Newman globally using npm.
- **Run Newman Tests**: Executes the Postman collection tests using Newman. The `--insecure` flag is used to bypass self-signed certificate issues.

## Local Setup

To run the tests locally using Postman CLI and Newman, follow these steps:

### Prerequisites

- [Node.js](https://nodejs.org/en/download/) installed.
- [Postman](https://www.postman.com/downloads/) installed.

### Steps

1. **Install Newman**:
    ```sh
    npm install -g newman
    ```

2. **Run Newman Tests**:
    ```sh
    newman run "C:\Users\Miray\AppData\Local\Postman\app-11.2.0\WebAPI.postman_collection.json" -e "C:\Users\Miray\AppData\Local\Postman\app-11.2.0\LibraryEnv.postman_environment.json" --insecure
    ```

### Localhost Limitation
Due to the limitations of running tests on localhost, the above GitHub Actions configuration is demonstrated without an actual deployment of the backend service. In a real-world scenario, the backend would need to be deployed to a public environment accessible by GitHub Actions.

### Note

The current configuration and tests are designed to run against a local instance of the API. Since the API is not deployed to a public environment, the GitHub Actions workflow will not be able to execute the tests successfully. The configuration files and scripts serve as a demonstration of the setup process.

## Files and Structure

- **`.github/workflows/newman.yml`**: GitHub Actions workflow configuration.
- **`postman/WebAPI.postman_collection.json`**: Postman collection file.
- **`postman/LibraryEnv.postman_environment.json`**: Postman environment file.

## Conclusion

This capstone project showcases the integration of Postman CLI and Newman in a CI pipeline using GitHub Actions. Despite the limitation of not having access to a deployed API, the configuration and scripts demonstrate the ability to set up and automate API tests effectively.

  For any inquiries or further information, please reach out through my GitHub profile: [chiturca](https://github.com/chiturca).  

<br/>

 ***Miray Sönmez***  
<p>
 Software Tester
</p>

<br/>
<br/>
<br/>



------------------------------------------------------------------------------------------------------------------------------------

<p align="center">
</p>
<p align="center">
  <a href="https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/graphs/contributors"><img src="https://img.shields.io/github/contributors/Tobeto-dotNet2A-Pair2/LibraryManagementSystem.svg?style=for-the-badge"></a>
  <a href="https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/network/members"><img src="https://img.shields.io/github/forks/Tobeto-dotNet2A-Pair2/LibraryManagementSystem.svg?style=for-the-badge"></a>
  <a href="https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/stargazers"><img src="https://img.shields.io/github/stars/Tobeto-dotNet2A-Pair2/LibraryManagementSystem.svg?style=for-the-badge"></a>
  <a href="https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/issues"><img src="https://img.shields.io/github/issues/Tobeto-dotNet2A-Pair2/LibraryManagementSystem.svg?style=for-the-badge"></a>
  <a href="https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/blob/master/LICENSE"><img src="https://img.shields.io/github/license/Tobeto-dotNet2A-Pair2/LibraryManagementSystem.svg?style=for-the-badge"></a>
  <a href="https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem.git"> <img src="https://komarev.com/ghpvc/?username=Tobeto-dotNet2A-Pair2&label=Project%20views&color=0e75b6&style=for-the-badge" alt="Project views" /> </a>
</p>
<p align="center">
 <h3 align="center">Kütüphane Yönetim Sistemi</h1>
  <p align="center">

### 💻 Proje Hakkında
Bu proje, kitap ödünç alma, iade etme ve envanter yönetimi gibi fonksiyonları sağlayan bir kütüphane yönetim sistemi tasarlamak amacıyla geliştirilmiştir.

### 🧰 Kullanılan Teknolojiler

### 🔧 Backend
- **Programlama Dili**: C#
- **Geliştirme Platformu**: .NET 8.0
- **Mimari**: Narchitecture

### 🔧 Frontend
- **Framework**: Angular
- **Mimari**: Feature-Based Architecture
- **Teknolojiler**: 
  - Bootstrap
  - JavaScript
  - TypeScript
  - SCSS

### 💼 Veri Tabanı Yönetim Sistemi
- **Veri Tabanı**: Microsoft SQL Server

### 🔒 Bulut Bilişim Platformu
- **Platform**: Amazon Web Services (AWS)

### ⚙️ Diğer Teknolojiler
- 📩 **Mail Hizmeti**: Papercut SMTP
- 📸 **Medya Yönetimi**: Cloudinary

### 📊 Proje Diyagramı
![LMS_Diagram](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/116646963/05500231-bcb4-4083-a4f5-af4434c2e6b6)


### 📸 Proje Görselleri 


![responsiveLibrary](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/91956970/fd2c6ae2-1957-4196-a9fe-6db06c0c7434)


![dark](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/91956970/7146139d-6695-4e4e-8fee-a856d5b75c65)


![image](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/133245392/b8040efd-35d8-4fed-acbd-690d113ef18f)
![image](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/133245392/22dbd99a-3287-42a6-afe5-dca93202b0d8)
![image](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/133245392/17dc48d0-08a7-4961-a7d4-65f604d5c9bb)
![image](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/133245392/78982900-05a5-40fc-8f57-b026f81795f6)
![image](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/assets/133245392/43816360-234f-4a73-8c23-d1a63fe7a774)




  
### 🚧 Yol Haritası
Önerilen özellikler ve bilinen sorunlar için [open issues](https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem/issues) inceleyebilirsiniz.

### 🤝 Katkıda Bulunma
Açık kaynak topluluğunu bu kadar harika bir yer yapan şey, öğrenme, ilham alma ve yaratma sürecine katkıda bulunmaktır. Yaptığınız her türlü katkı çok takdir edilmektedir.

Katkıda bulunmak için:

- Projeyi Fork'layın
- Kendi Özellik Dalınızı Oluşturun (git checkout -b feature/<AmazingFeature>)
- Yaptığınız Değişiklikleri Commit Edin (git commit -m '')
- Dalınıza Push Edin (git push origin feature/<AmazingFeature>)
- Bir Pull Request Açın


### ⚖️ Lisans
MIT Lisansı altında dağıtılmaktadır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

### 📧 İletişim

Proje Linki: https://github.com/Tobeto-dotNet2A-Pair2/LibraryManagementSystem

### 👩‍💻👨‍💻 Takım Üyeleri

Bu projeye katkıda bulunan herkese teşekkür ederiz:

- **Ayşe KARDAŞ** - [GitHub Profili](https://github.com/aysekardas)
- **Cihan YÜKSEL** - [GitHub Profili](https://github.com/ycihan0)
- **Zeynep YAŞAR** - [GitHub Profili](https://github.com/yasarzeynep)
- **Güven ÇABAT** - [GitHub Profili](https://github.com/fakepokeball)
- **Ebru Zeynep ADIGÜZEL** - [GitHub Profili](https://github.com/ebruadiguzel)
  
### 🙏 Teşekkürler



