# 🎮 Clase 1 — Consola, Git y Lógica C# en Unity

> Proyecto de práctica: vas a usar la consola de Unity, versionar tu código con Git y escribir tu primera lógica en C#.

---

## ⚙️ Setup Inicial

### 1. Requisitos
- [Unity Hub](https://unity.com/download) con **Unity 6** instalado
- [Git](https://git-scm.com/) + cuenta en [GitHub](https://github.com)

### 2. Clonar el repositorio
```bash
git clone https://github.com/KinnaGt/Pira-Introduccion-Unity.git
```

### 3. Abrir en Unity
Unity Hub → **Open** → seleccionar la carpeta del proyecto.  
Cargar la escena: `Assets/Clase1/Scenes/Class_1_Task.unity`

---

## 🔁 Control de versiones — Git

Antes de empezar a codear, creá tu propio repositorio en GitHub y vinculalo al proyecto. A medida que avancés, guardá tu progreso con commits.

```bash
git add .
git commit -m "descripción de lo que hiciste"
git push origin main
```

**Entregable mínimo: al menos 2 commits con mensajes descriptivos.**

---

## 📝 Tareas

### Script 1 — `JuanSalvo.cs`

Abrí el archivo en `Assets/Clase1/Scripts/JuanSalvo.cs`.

**TAREA 1: Declaración y Encapsulamiento**
Declará tres variables privadas al comienzo de la clase:nombre,edad y (altura). 


**TAREA 2: Concatenación**
Dentro de `MostrarDatos()`, asigná a la variable `_finalMessage` una frase que combine texto estático con tus variables usando el operador `+`

**TAREA 3: Lógica Condicional**
Completá el método `Contestar()`. Debes evaluar una de tus variables mediante un bloque `if/else` y asignar un nuevo mensaje a `_finalMessage` dependiendo del resultado.
*   *Ejemplo:* Si la altura es mayor a 2.0f, el mensaje debe ser "¡Podrías jugar en la NBA!".

---

### Script 2 — `LogButtons.cs`

Completá los métodos usando la clase `Debug`:

| Método | Consigna | Ícono en consola |
|--------|----------|-----------------|
| `LogInfoMessage()` | Imprimí un mensaje normal | ⬜ blanco |
| `LogWarningMessage()` | Imprimí una advertencia | 🔶 amarillo |
| `LogErrorMessage()` | Imprimí un error | 🔴 rojo |

**PLUS — `LogErrorMessage()`:** Investigá cómo hacer que Unity se **pause automáticamente** (Break) al ejecutar ese método mediante código.

---

## 🧠 Conceptos de C# que necesitás

### Atributos de Unity
*   `[SerializeField]`: Permite que Unity "vea" y guarde una variable privada desde el editor.

### Operadores de Comparación
```csharp
if (altura >= 1.80f) { /* Lógica */ } // Mayor o igual
if (edad == 18) { /* Lógica */ }      // Igualdad
if (nombre != "Juan") { /* Lógica */ } // Diferente
```

---

## ✅ Checklist de entrega

- [ ] Repositorio en GitHub con la tarea.
- [ ] `JuanSalvo.cs`: Variables declaradas con `[SerializeField]`.
- [ ] `JuanSalvo.cs`: `MostrarDatos()` construye el mensaje correctamente.
- [ ] `JuanSalvo.cs`: **Tarea 3** (Lógica condicional) implementada en `Contestar()`.
- [ ] `LogButtons.cs`: Los 3 métodos de log implementados.
- [ ] **PLUS:** Unity se pausa al presionar el botón de error.
- [ ] **PLUS:** Se cambiaron los sprites de los botones por los de `Assets/Clase1/Art/Buttons`.
- [ ] La escena corre **sin errores** en la consola.

---

## 📚 Recursos

- [Debug.Break — Unity Scripting API](https://docs.unity3d.com/ScriptReference/Debug.Break.html)
- [SerializeField — Unity Manual](https://docs.unity3d.com/ScriptReference/SerializeField.html)
- [String Interpolation in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)

---
