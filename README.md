# KASIR APEX

### RM Minang Bpk Samsul — V0.0.1

```text
========================================
            KASIR APEX V0.0.1
        RM MINANG BPK SAMSUL
========================================

  SIMPLE CONSOLE-BASED CASHIER SYSTEM

========================================
```

## About

**Kasir Apex** is a simple C# console-based cashier application designed for **RM Minang Bpk Samsul**.

The program allows the cashier to select a menu item, enter the customer's name and quantity, calculate the subtotal and 10% tax, process the customer's payment, and generate a simple digital receipt.

Built as a small programming project, it demonstrates how fundamental C# concepts can be combined to create a functional point-of-sale system.

---

## Features

* Menu and price display
* Customer name input
* Food selection
* Quantity input
* Automatic subtotal calculation
* 10% tax calculation
* Payment input
* Automatic change calculation
* Digital receipt generation
* Sold-out handling for invalid menu selections

---

## Menu

The current version contains 10 menu items:

|  ID  | Menu           |     Price |
| :--: | -------------- | --------: |
|  `1` | Rendang        | Rp 35.000 |
|  `2` | Ayam Pop       | Rp 28.000 |
|  `3` | Dendeng Balado | Rp 38.000 |
|  `4` | Gulai Tunjang  | Rp 40.000 |
|  `5` | Gulai Ayam     | Rp 30.000 |
|  `6` | Gulai Ikan     | Rp 32.000 |
|  `7` | Sambal Ijo     |  Rp 5.000 |
|  `8` | Telur Balado   | Rp 10.000 |
|  `9` | Perkedel       |  Rp 7.000 |
| `10` | Nasi Putih     |  Rp 8.000 |

---

## How It Works

The application follows a straightforward cashier workflow:

```text
              START
                |
                v
        DISPLAY MENU
                |
                v
       INPUT CUSTOMER NAME
                |
                v
        INPUT FOOD ITEM
                |
                v
         INPUT QUANTITY
                |
                v
       CALCULATE SUBTOTAL
                |
                v
          ADD 10% TAX
                |
                v
       INPUT PAYMENT
                |
                v
       CALCULATE CHANGE
                |
                v
        PRINT RECEIPT
                |
                v
               END
```

---

## Example

A customer named `Budi` purchases 2 portions of Rendang.

```text
Nama Pembeli : Budi

Barang yang dibeli :
Rendang

Jumlah Barang :
2
```

The program calculates:

```text
Rendang
Rp 35.000 × 2

Subtotal : Rp 70.000
Pajak    : Rp 7.000
Total    : Rp 77.000
```

If the customer pays Rp 100.000:

```text
Uang Dibayarkan : Rp 100.000
Kembalian       : Rp 23.000
```

The program then generates a receipt.

```text
----------------------------
-   RM Minang Bpk Samsul   -
----------------------------

Pembeli : Budi

Makanan : Rendang

Jumlah  : 2

Total   : 77000
Pajak 10% : 7000

----------------------------
-   Maacih Nyaaaaaak!!!!   -
----------------------------
```

---

## Tax System

The application currently applies a fixed **10% tax**.

```csharp
const double PAJAK = 0.10;
```

The tax is calculated from the subtotal:

```text
Tax = Subtotal × 10%
```

The final price is then:

```text
Total = Subtotal + Tax
```

---

## Technologies

```text
Language    : C#
Framework   : .NET
Interface   : Console / CLI
Version     : V0.0.1
Project Type: Point of Sale / Cashier
Status      : DEVELOPMENT
```

### Programming Concepts

This project demonstrates:

* Variables
* Integer and floating-point values
* Constants
* Console input/output
* `if / else if / else`
* Arithmetic operations
* String comparison
* User input conversion
* Basic receipt generation

---

## Installation

Make sure the **.NET SDK** is installed on your system.

Place the source code inside a C# Console project.

Build the project:

```bash
dotnet build
```

Run the application:

```bash
dotnet run
```

---

## Project Structure

```text
Kasir-Apex/
│
├── Program.cs
├── README.md
├── LICENSE
└── Kasir-Apex.csproj
```

The main cashier logic is contained in:

```text
Program.cs
```

---

## Known Limitations

This is an early version, so the application currently has several limitations:

* Only one food item can be purchased per transaction
* Food names must be entered exactly as expected
* Invalid numeric input can cause the program to terminate
* No inventory management
* No persistent transaction history
* No graphical interface
* Tax is fixed at 10%
* Currency formatting is still basic

These limitations are intentional opportunities for future development.

---

## Future Development

Possible improvements for future versions:

```text
[+] Number-based food selection
[+] Multiple items per transaction
[+] Better input validation
[+] Proper Indonesian Rupiah formatting
[+] Automatic inventory tracking
[+] Discount system
[+] Payment validation
[+] Transaction history
[+] Daily sales report
[+] Receipt printing
[+] Database integration
[+] Staff login system
[+] Graphical interface
```

A more advanced version could eventually become:

```text
========================================
              KASIR APEX
========================================

  TRANSACTION
  --------------------------------------
  Customer : Budi

  ITEM                 QTY       PRICE
  --------------------------------------
  Rendang               2      Rp 70.000
  Nasi Putih            2      Rp 16.000
  --------------------------------------
  SUBTOTAL                       Rp 86.000
  TAX 10%                         Rp 8.600
  --------------------------------------
  TOTAL                          Rp 94.600

  PAYMENT                       Rp 100.000
  CHANGE                          Rp 5.400

========================================
          TRANSACTION COMPLETE
========================================
```

---

## Version

```text
Project  : Kasir Apex
Business : RM Minang Bpk Samsul
Version  : V0.0.1
Language : C#
Platform : .NET Console
Status   : DEVELOPMENT
```

---

## License

## License

**Kasir Apex** is open source software licensed under the **MIT License**.

You are free to:

* Use the project
* Copy the source code
* Modify and customize it
* Add new features
* Use it as a learning resource
* Redistribute the original or modified version
* Use it as the foundation for another project

The only requirement is that the original copyright and license notice are retained in copies or substantial portions of the software.

See the [`LICENSE`](LICENSE) file for the complete license terms.

