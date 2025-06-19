# Singleton Pattern

## Overview

This assignment demonstrates the **Singleton Design Pattern** in Java using a simple console application. The Singleton pattern ensures that a class has **only one instance** and provides a **global point of access** to that instance.

This is particularly useful in scenarios such as:
- Managing a shared resource (e.g., a database connection or configuration object).
- Implementing logging services.
- Controlling access to a central resource.

---

### Singleton Class

```java
class Singleton {
    static Singleton instance = new Singleton(); 
    
    private Singleton() {
        System.out.println("Singleton Created.");
    }

    void helloWorld() {
        System.out.println("Hello World!");
    }
}
```

### Main Class
```java
public class exercise1 {
    public static void main(String[] args) {
        Singleton.instance.helloWorld();
    }
}
```

## How to Run
### Prerequisites
- Java JDK 8 or later must be installed
- Any terminal or command prompt

---

### Compilation

```bash
javac exercise1.java
```

### Execution
```bash
java exercise1
```

## Output
```bash
Singleton Created.
Hello World!
```