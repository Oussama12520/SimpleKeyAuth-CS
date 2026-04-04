<table>
  <tr>
    <td>
      <img src="https://github.com/Oussama12520.png" alt="Profile" width="120" height="120" style="border-radius:50%;">
    </td>
    <td>
<pre>
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


<style>
  @import url('https://fonts.googleapis.com/css2?family=Share+Tech+Mono&display=swap');

  .hero {
    font-family: 'Share Tech Mono', monospace;
    background: #0d1117;
    border-radius: 12px;
    padding: 2rem 1.5rem 1.5rem;
    overflow: hidden;
    position: relative;
  }

  .scanline {
    position: absolute;
    top: 0; left: 0; right: 0; bottom: 0;
    background: repeating-linear-gradient(
      to bottom,
      transparent,
      transparent 3px,
      rgba(255,255,255,0.012) 3px,
      rgba(255,255,255,0.012) 4px
    );
    pointer-events: none;
    z-index: 2;
  }

  .grid-bg {
    position: absolute;
    top: 0; left: 0; right: 0; bottom: 0;
    background-image:
      linear-gradient(rgba(0,255,136,0.04) 1px, transparent 1px),
      linear-gradient(90deg, rgba(0,255,136,0.04) 1px, transparent 1px);
    background-size: 32px 32px;
    z-index: 0;
  }

  .content {
    position: relative;
    z-index: 3;
    display: flex;
    align-items: center;
    gap: 2rem;
    flex-wrap: wrap;
  }

  .avatar-wrap {
    position: relative;
    flex-shrink: 0;
  }

  .avatar-ring {
    width: 120px;
    height: 120px;
    border-radius: 50%;
    position: relative;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .avatar-ring::before {
    content: '';
    position: absolute;
    inset: -3px;
    border-radius: 50%;
    background: conic-gradient(#00ff88, #00aaff, #ff00aa, #00ff88);
    animation: spin 4s linear infinite;
    z-index: -1;
  }

  .avatar-ring::after {
    content: '';
    position: absolute;
    inset: -1px;
    border-radius: 50%;
    background: #0d1117;
    z-index: -1;
  }

  @keyframes spin {
    to { transform: rotate(360deg); }
  }

  .avatar-ring img {
    width: 114px;
    height: 114px;
    border-radius: 50%;
    display: block;
    position: relative;
    z-index: 1;
  }

  .status-dot {
    position: absolute;
    bottom: 6px;
    right: 6px;
    width: 14px;
    height: 14px;
    background: #00ff88;
    border-radius: 50%;
    border: 2px solid #0d1117;
    animation: pulse 2s ease-in-out infinite;
    z-index: 4;
  }

  @keyframes pulse {
    0%, 100% { box-shadow: 0 0 0 0 rgba(0,255,136,0.7); }
    50% { box-shadow: 0 0 0 6px rgba(0,255,136,0); }
  }

  .ascii-wrap {
    flex: 1;
    min-width: 0;
    overflow: hidden;
  }

  .ascii-art {
    font-size: clamp(7px, 1.3vw, 11px);
    line-height: 1.2;
    white-space: pre;
    color: transparent;
    background: linear-gradient(135deg, #00ff88 0%, #00ccff 40%, #aa00ff 80%, #ff0066 100%);
    -webkit-background-clip: text;
    background-clip: text;
    animation: shimmer 6s ease-in-out infinite alternate;
    filter: drop-shadow(0 0 8px rgba(0,255,136,0.35));
    letter-spacing: 0.05em;
    background-size: 200% 200%;
  }

  @keyframes shimmer {
    0%   { background-position: 0% 50%; filter: drop-shadow(0 0 6px rgba(0,255,136,0.3)); }
    50%  { background-position: 100% 50%; filter: drop-shadow(0 0 14px rgba(0,200,255,0.5)); }
    100% { background-position: 0% 50%; filter: drop-shadow(0 0 6px rgba(180,0,255,0.3)); }
  }

  .tagline {
    margin-top: 0.75rem;
    display: flex;
    align-items: center;
    gap: 0.5rem;
    font-size: 12px;
    color: #4a9e6e;
    letter-spacing: 0.15em;
    text-transform: uppercase;
  }

  .cursor {
    display: inline-block;
    width: 8px;
    height: 14px;
    background: #00ff88;
    animation: blink 1.1s step-end infinite;
    vertical-align: middle;
    margin-left: 2px;
    border-radius: 1px;
  }

  @keyframes blink {
    0%, 100% { opacity: 1; }
    50% { opacity: 0; }
  }

  .badges {
    margin-top: 1.25rem;
    display: flex;
    gap: 8px;
    flex-wrap: wrap;
  }

  .badge {
    font-family: 'Share Tech Mono', monospace;
    font-size: 11px;
    padding: 3px 10px;
    border-radius: 4px;
    letter-spacing: 0.05em;
    animation: fadeIn 0.6s ease forwards;
    opacity: 0;
  }

  .badge-green  { background: rgba(0,255,136,0.1); color: #00ff88; border: 1px solid rgba(0,255,136,0.25); animation-delay: 0.4s; }
  .badge-blue   { background: rgba(0,170,255,0.1); color: #00aaff; border: 1px solid rgba(0,170,255,0.25); animation-delay: 0.6s; }
  .badge-purple { background: rgba(170,0,255,0.1); color: #bb44ff; border: 1px solid rgba(170,0,255,0.25); animation-delay: 0.8s; }

  @keyframes fadeIn {
    from { opacity: 0; transform: translateY(6px); }
    to   { opacity: 1; transform: translateY(0); }
  }

  .ascii-wrap { animation: slideIn 0.7s cubic-bezier(0.22,1,0.36,1) both; }
  @keyframes slideIn {
    from { opacity: 0; transform: translateX(20px); }
    to   { opacity: 1; transform: translateX(0); }
  }

  .avatar-wrap { animation: popIn 0.6s cubic-bezier(0.34,1.56,0.64,1) both; animation-delay: 0.1s; }
  @keyframes popIn {
    from { opacity: 0; transform: scale(0.8); }
    to   { opacity: 1; transform: scale(1); }
  }

  .corner {
    position: absolute;
    width: 16px; height: 16px;
    border-color: rgba(0,255,136,0.35);
    border-style: solid;
    z-index: 3;
  }
  .corner-tl { top: 10px; left: 10px; border-width: 2px 0 0 2px; }
  .corner-tr { top: 10px; right: 10px; border-width: 2px 2px 0 0; }
  .corner-bl { bottom: 10px; left: 10px; border-width: 0 0 2px 2px; }
  .corner-br { bottom: 10px; right: 10px; border-width: 0 2px 2px 0; }
</style>

<div class="hero">
  <div class="grid-bg"></div>
  <div class="scanline"></div>
  <div class="corner corner-tl"></div>
  <div class="corner corner-tr"></div>
  <div class="corner corner-bl"></div>
  <div class="corner corner-br"></div>

  <div class="content">
    <div class="avatar-wrap">
      <div class="avatar-ring">
        <img src="https://github.com/Oussama12520.png" alt="Profile">
      </div>
      <div class="status-dot"></div>
    </div>

    <div class="ascii-wrap">
      <div class="ascii-art">██╗ ██████╗ ███████╗ █████╗ ███╗   ███╗ █████╗ 
██║██╔═══██╗██╔════╝██╔══██╗████╗ ████║██╔══██╗
██║██║   ██║███████╗███████║██╔████╔██║███████║
╚═╝██║   ██║╚════██║██╔══██║██║╚██╔╝██║██╔══██║
██╗╚██████╔╝███████║██║  ██║██║ ╚═╝ ██║██║  ██║
╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝</div>

      <div class="tagline">
        <span>// full-stack developer</span>
        <span class="cursor"></span>
      </div>

      <div class="badges">
        <span class="badge badge-green">open to work</span>
        <span class="badge badge-blue">building cool stuff</span>
        <span class="badge badge-purple">open source</span>
      </div>
    </div>
  </div>
</div>




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
