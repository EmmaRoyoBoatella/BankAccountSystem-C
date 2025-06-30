# Bank Account Management System in C

## 1. Introduction
   This project implements a console-based bank account management system in C, allowing up to 100 clients to be registered with unique account codes and initial balances. Users can perform deposits and withdrawals, query clients whose balances exceed a specified threshold, and view or export all account data via a simple menu-driven interface.

## 2. Project Structure

* **Library Imports:**
  Uses `<stdio.h>` and `<stdlib.h>` for input/output, memory allocation, and program control.
* **Data Input (`PedirDatos`):**
  Prompts the user to enter each client’s integer code and starting balance, storing them in parallel arrays.
* **Transaction Handling (`Movimientos`):**
  Supports deposit and withdrawal operations by client code, updating the corresponding balance after validating the account exists.
* **Client Search (`BuscarClientes`):**
  Requests a monetary threshold and lists all clients whose balances exceed that amount.
* **Data Display (`VerDatos` / `EscribirDatos`):**

  * `VerDatos` prints each client’s code alongside its current balance.
  * `EscribirDatos` (optional) writes client codes to an output stream or file.
* **User Interface (`Menu` / `Limpiar`):**

  * `Menu` displays the action list (1: Transactions, 2: Search by Threshold, 3: View All, 4: Exit) and returns the selected option.
  * `Limpiar` clears the console between operations for readability.
* **Main Loop:**

  * Reads the number of clients, calls `PedirDatos`, then repeatedly invokes `Menu` until the user chooses to exit.
  * Routes each menu choice to the appropriate function, with input validation and user feedback on invalid selections.

## 3. How to Compile & Run

```bash
# Compile the source file
gcc PR0_P1_EmmaRoyoBoatella.c -o bank_app

# Run the application
./bank_app
```

* Follow on-screen prompts to register clients and perform operations.
* Exit by selecting option 4 from the menu.

## 4. Possible Extensions

* **Persistent Storage:** Read/write client data to a text or binary file to preserve state across runs.
* **Enhanced Reporting:** Export transaction logs or generate summary reports (e.g., average balance, highest-value accounts).
* **Input Validation:** Add checks for negative balances, non-existent account codes, or malformed input.
* **Thread Safety / Concurrency:** Adapt for multi-threaded access in a networked or GUI context.

## 5. Client Data Handling
   All client information is entered at runtime via the console; no external datasets are required. Future versions could load initial data from a CSV or database.
