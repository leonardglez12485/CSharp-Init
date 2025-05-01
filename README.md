# HelloApp

HelloApp es una aplicación de consola escrita en C# que demuestra conceptos básicos de programación, como el uso de variables, tipos de datos, cálculos y más.

## Estructura del Proyecto

El proyecto tiene la siguiente estructura:

HelloApp/ ├── .gitignore ├── HelloApp.csproj ├── HelloApp.sln ├── Program.cs ├── 01-bases/ │ ├── Variables.cs │ ├── StringType.cs │ ├── SalaryCalculator.cs │ ├── NumericValues.cs │ ├── HomeWork.cs ├── bin/ │ └── Debug/ │ └── net9.0/ ├── obj/


### Archivos principales

- **`Program.cs`**: Contiene el punto de entrada de la aplicación.
- **`01-bases/`**: Carpeta que contiene módulos individuales para diferentes funcionalidades:
  - `Variables.cs`: Demostración del uso de variables.
  - `StringType.cs`: Operaciones con cadenas de texto.
  - `SalaryCalculator.cs`: Calculadora de salario por hora.
  - `NumericValues.cs`: Uso de diferentes tipos numéricos.
  - `HomeWork.cs`: Reporte de ventas como ejemplo práctico.

## Requisitos

- .NET SDK 9.0 o superior.

## Cómo ejecutar el proyecto

1. Clona este repositorio en tu máquina local.
2. Abre una terminal en la carpeta raíz del proyecto.
3. Ejecuta el siguiente comando para compilar y ejecutar la aplicación:

   ```bash
   dotnet run