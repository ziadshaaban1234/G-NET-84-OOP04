# Smart Delivery Management System

A C# console application for managing different types of shipments and demonstrating basic Object-Oriented Programming concepts.

## Project Description

The system manages three types of shipments:

- Standard Shipment
- Express Shipment
- International Shipment

Each shipment has its own estimated cost, tracking status, and insurance calculation.

## OOP Concepts

- Abstraction
- Inheritance
- Encapsulation
- Interfaces
- Polymorphism

## Features

- Add shipments to the delivery center.
- Display shipment details.
- Display tracking status for shipments.
- Calculate insurance for each shipment.
- Demonstrate interface polymorphism using `ITrackable` and `IInsurable`.

## Project Structure

```text
Contracts
├── ITrackable.cs
└── IInsurable.cs

Models
├── Shipment.cs
├── StandardShipment.cs
├── ExpressShipment.cs
├── InternationalShipment.cs
└── DeliveryAddress.cs

Services
├── DeliveryCenter.cs
└── DeliveryReport.cs

Program.cs
