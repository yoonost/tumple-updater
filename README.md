# tumple-updater

This repository is a complementary tool for the **yoonost/tumple-launcher** project.

## Introduction

The **Tumple Updater** is designed to facilitate the update process for the **Tumple Launcher** by automatically transferring files from a specified cache directory to the main directory. It then initiates the launcher to ensure a seamless update experience for the users.

## Usage

### Prerequisites
- .NET Core Runtime

### Instructions
1. Clone or download this repository.
2. Compile the program using your preferred IDE or the command line.
3. Run the compiled executable with two arguments:
    - The cache directory containing the updated files.
    - The main directory where the files should be updated.

Example usage:

tumple-updater.exe "C:\UpdateCache" "C:\TumpleLauncher"

## Troubleshooting

If you encounter any issues during the update process, please follow these steps:
1. Check that both the cache and main directories exist and are accessible.
2. Ensure the file structure within the cache directory matches the expected structure.
3. Contact the project management for further assistance.

For any inquiries or to report bugs, feel free to create an issue in this repository.
