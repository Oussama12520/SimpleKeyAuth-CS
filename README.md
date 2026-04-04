<table>
  <tr>
    <!-- Profile Photo -->
    <td>
      <img src="https://github.com/Oussama12520.png" alt="Profile" width="120" height="120" style="border-radius: 50%;">
    </td>

    <!-- ASCII Logo -->
    <td>
      <pre style="font-size: 14px; line-height: 1.1;">
██╗ ██████╗ ███████╗ █████╗ ███╗   ███╗ █████╗ 
██║██╔═══██╗██╔════╝██╔══██╗████╗ ████║██╔══██╗
██║██║   ██║███████╗███████║██╔████╔██║███████║
╚═╝██║   ██║╚════██║██╔══██║██║╚██╔╝██║██╔══██║
██╗╚██████╔╝███████║██║  ██║██║ ╚═╝ ██║██║  ██║
╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝
      </pre>
    </td>
  </tr>
</table>
```
██╗ ██████╗ ███████╗ █████╗ ███╗   ███╗ █████╗ 
██║██╔═══██╗██╔════╝██╔══██╗████╗ ████║██╔══██╗
██║██║   ██║███████╗███████║██╔████╔██║███████║
╚═╝██║   ██║╚════██║██╔══██║██║╚██╔╝██║██╔══██║
██╗╚██████╔╝███████║██║  ██║██║ ╚═╝ ██║██║  ██║
╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝
```
# Simple Login - KeyAuth Integration

A simple, secure, and modern C# Windows Forms application that demonstrates how to integrate the KeyAuth authentication system. This project provides a solid foundation for building applications that require user authentication, license validation, and secure access control.

## Features

- **Secure Login**: Authenticate users using their KeyAuth credentials (username and password).
- **KeyAuth Integration**: Pre-configured with the KeyAuth API wrapper for seamless communication.
- **Modern UI**: A clean and responsive Windows Forms interface using the Montserrat font.
- **Asynchronous Operations**: Uses async/await for non-blocking UI during authentication.
- **Encrypted Communication**: Leverages Ed25519 for secure data signing.

## Getting Started

### Prerequisites

- **Visual Studio 2019/2022** (or any C# compatible IDE).
- **.NET Framework 4.7.2** or higher.
- A **KeyAuth** account (Create one at [keyauth.win](https://keyauth.win)).

### Configuration

1. **Open the Project**: Load the `login.sln` file in Visual Studio.
2. **Setup KeyAuth Credentials**:
   - Open `login.cs`.
   - Locate the `KeyAuthApp` initialization (around line 22).
   - Replace the empty strings with your KeyAuth application information:
     ```csharp
     public static KeyAuth.api KeyAuthApp = new KeyAuth.api(
         name: "Your_App_Name",
         ownerid: "Your_Owner_ID",
         version: "1.0"
     );
     ```
3. **Build and Run**: Press `F5` to build and launch the application.

## Project Structure

- `login.cs`: The main form handling the UI and login logic.
- `KeyAuth.cs`: The API wrapper for interacting with KeyAuth services.
- `Ed25519.cs`: Cryptographic utilities for secure signatures.
- `Program.cs`: The entry point for the application.

## Usage

1. Launch the application.
2. Enter your **Username** and **Password** registered on your KeyAuth dashboard.
3. Click **LOGIN**.
4. The status label at the bottom will provide feedback on whether the login was successful.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details (if applicable).

---
*Created for the community.*
