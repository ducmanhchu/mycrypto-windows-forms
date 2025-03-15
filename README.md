# MyCrypto - A Simple Blockchain-Based Transaction System

## Introduction
MyCrypto is a Windows Forms application that simulates the core functionalities of a cryptocurrency system. It allows users to create transactions, sign them with a private key, verify transaction validity, and add them to a blockchain. The system also supports mining blocks and tracking balances.

## Features
- **Blockchain System**: A simple blockchain that stores transaction data.
- **Key Pair Generation**:
  - Generate a private and public key pair for transactions.
  - The private key is used to sign transactions.
- **Mining Mechanism**:
  - Mine a new block to receive mining rewards.
  - Mining confirms pending transactions.
- **Transaction Management**:
  - Create transactions with sender and receiver addresses.
  - Sign transactions using RSA digital signatures.
  - Validate transactions using public keys.
- **Balance Tracking**:
  - Check user balances based on blockchain transactions.
- **User Interface**:
  - Windows Forms-based UI with separate UserControls for blockchain and transactions.
  - Displays blockchain blocks and pending transactions.

## Installation
### Prerequisites
- Windows OS
- .NET 8.0 SDK
- Visual Studio (Recommended for development)

### Steps to Run
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/MyCrypto.git](https://github.com/ducmanhchu/mycrypto-windows-forms
2. Open the project in Visual Studio.
3. Build and run the application.

## Usage

1. Generate a key pair (private and public keys) for transactions (default balance is 0).
2. Mine a block to earn rewards.
3. Create transactions by entering receiver address and amount.
4. Sign the transaction using the private key.
5. Add the transaction to the pending list.
6. Mine a new block to confirm transactions.
7. View updated blockchain and balances.

## Technologies Used
- C# (Windows Forms)
- .NET 8.0
- RSA Encryption (for digital signatures)
- SHA-256 (for hashing transactions)

## Future Improvements
- Implement network-based blockchain synchronization.
- Add a decentralized mining mechanism.
- Enhance security features for private key storage.

## License
This project is open-source under the Apache - 2.0 License.
