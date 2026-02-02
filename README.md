# Pub-Sub System – Low Level Design (LLD)

A  Machine Coding solution for designing an **in-memory Publish-Subscribe System** using **C#**, focusing on clean architecture, thread safety, and extensibility.

---

## 🚀 Features

- Topic creation
- Subscriber registration & removal
- Asynchronous message publishing
- Thread-safe message delivery
- Loose coupling between components

---

## 🧠 Core Concepts

- Publisher publishes messages to a topic
- Subscribers receive messages asynchronously
- Broker handles routing and delivery
- Topics maintain subscriber lists

---

## 🏗️ Architecture

Domain → Core entities & interfaces
Services → Broker & dispatch logic
Application → Demo runner
ConsoleApp → Entry point

## 🔄 Message Flow

1. Publisher publishes a message to a topic
2. Broker fetches topic subscribers
3. Message dispatched asynchronously
4. Each subscriber processes message independently

---

## 🔐 Thread Safety

- Concurrent collections
- Non-blocking publish
- Independent subscriber execution

---

## 🧩 Design Patterns Used

- Observer Pattern (core)
- Strategy Pattern (delivery mechanism)
- SOLID Principles
- Dependency Inversion

- ## 🛠️ Tech Stack

- Language: **C#**
- Execution: Console App
- Storage: In-memory

- ## ▶️ How to Run

-```bash
-dotnet build
-dotnet run

-## Author
-Abhishek
