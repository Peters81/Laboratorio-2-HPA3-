# Laboratorio 2 - Clases en C#

## Información del laboratorio

| Dato | Información |
|---|---|
| **Asignatura** | Herramientas de la Programación Aplicada III (.NET) |
| **Laboratorio** | Laboratorio #2 |
| **Tema** | Modelado de Clases y Gestión de Atributos mediante Propiedades en C# |
| **Grupo** | 1IL133 |
| **Profesora** | Ing. Irina Fong |
| **Semestre** | II Semestre 2026 |


---

## Objetivos

🟢 Comprender y aplicar la estructura básica de una aplicación de consola en C#.

🟢 Diseñar y programar clases utilizando la convención de nomenclatura PascalCase.

🟢 Implementar métodos con y sin parámetros para modularizar el comportamiento de los objetos.

🟢 Utilizar los modificadores de acceso `public` y `private`.

🟢 Trabajar con variables de instancia y propiedades.

🟢 Aplicar los descriptores de acceso `get` y `set` para controlar la lectura y modificación de atributos. :contentReference[oaicite:1]{index=1}

---

## Contenido del laboratorio

En este laboratorio se trabajaron los fundamentos de la programación orientada a objetos en C#, mediante la creación de clases, instanciación de objetos, métodos, parámetros, variables de instancia y propiedades.

Los principales temas desarrollados fueron:

🟢 Estructura de programas por consola utilizando clases.

🟢 Uso de `Console.WriteLine`.

🟢 Creación de clases en Visual Studio.

🟢 Convención de nomenclatura `PascalCase`.

🟢 Creación e instanciación de objetos mediante `new`.

🟢 Métodos con y sin parámetros.

🟢 Variables de instancia.

🟢 Modificadores `public` y `private`.

🟢 Propiedades con `get` y `set`.


---

## Tecnologías utilizadas

🟢 **Lenguaje:** C#

🟢 **Plataforma:** .NET

🟢 **Tipo de aplicación:** Aplicación de consola

🟢 **IDE:** Visual Studio 2026

---

## Requisitos previos

Para ejecutar las actividades se necesita:

🟢 Windows.

🟢 Visual Studio 2026.

🟢 Conocimientos básicos de programación en C#.

🟢 Git, en caso de clonar el repositorio.

---

# Actividades desarrolladas

## 1. Actividad 1 - Clase LibroCalificaciones

En la primera actividad se trabajó con una aplicación de consola y la creación de una clase llamada `LibroCalificaciones`.

La clase contiene el método `MostrarMensaje`, encargado de mostrar un mensaje de bienvenida cuando es invocado.

También se trabajó la creación de una clase formal desde Visual Studio y la instanciación de objetos mediante el operador `new`. :contentReference[oaicite:4]{index=4}

### Conceptos aplicados

🟢 Creación de clases.

🟢 Métodos `public void`.

🟢 Instanciación de objetos.

🟢 Operador `new`.

🟢 Método `Main`.

### Evidencia

![Actividad 1 - Clase LibroCalificaciones](./imagenes/actividad1.png)

---

## 2. Actividad 2 - Método con parámetro

En la segunda actividad se trabajó la declaración de un método que recibe un parámetro.

El ejemplo utiliza el método `MostrarMensaje` con el parámetro `nombreCurso`, permitiendo enviar información desde el método `Main` hacia la clase.

También se trabajó el uso de `{0}` como marcador de posición para insertar valores dentro del texto mostrado mediante `Console.WriteLine`. :contentReference[oaicite:5]{index=5}

### Conceptos aplicados

🟢 Métodos con parámetros.

🟢 Argumentos.

🟢 Uso del operador punto `.`.

🟢 `Console.WriteLine`.

🟢 Marcadores de posición `{0}`.

🟢 Paso de información entre métodos.

### Evidencia

![Actividad 2 - Método con parámetro](./imagenes/actividad2.png)

---

## 3. Actividad 3 - Variables de instancia y propiedades

En la tercera actividad se trabajaron las variables de instancia y las propiedades de una clase.

Se utilizó la clase `LibroCalificaciones`, incorporando la variable de instancia `nombreCurso` y la propiedad `NombreCurso` para manipular dicho atributo. :contentReference[oaicite:6]{index=6}

También se estudiaron los modificadores de acceso `private` y `public`, así como los descriptores `get` y `set`.

El descriptor `get` permite obtener el valor de una variable de instancia, mientras que `set` permite modificarlo de manera controlada. :contentReference[oaicite:7]{index=7}

### Conceptos aplicados

🟢 Variables de instancia.

🟢 Propiedades.

🟢 Encapsulamiento.

🟢 Modificador `private`.

🟢 Modificador `public`.

🟢 Descriptor `get`.

🟢 Descriptor `set`.


### Evidencia

![Actividad 3 - Variables de instancia y propiedades](./imagenes/actividad3.png)

