# recursividad.Api

API REST en ASP.NET Core (.NET 9) que implementa ejercicios de recursividad matemática y puzzles algorítmicos.

## Stack tecnológico

- **Lenguaje**: C# con .NET 9 (net9.0)
- **Framework**: ASP.NET Core Web API (minimal configuration)
- **Características habilitadas**: Nullable reference types, Implicit usings
- **Dependencias**:
  - `Microsoft.AspNetCore.OpenApi` (versión 9.0.8)
- **Estructura del proyecto**:
  - `src/Controllers/` — controladores HTTP (`MathController.cs`, `PuzzlesController.cs`)
  - `src/Services/` — lógica del negocio (`MathService.cs`, `PuzzleService.cs`)
  - `src/Services/Contracts/` — interfaces de servicios (`IMathService.cs`, `IPuzzleService.cs`)
  - `src/Models/DTOs/` — DTOs para requests/responses (`MathDtos.cs`, `PuzzleDtos.cs`)
  - `Properties/launchSettings.json` — configuración de puertos y entorno

## ¿Qué hace este proyecto?

Esta API expone 5 ejercicios de recursividad implementados como endpoints HTTP:

### Controlador Math (`/api/math`)
- **POST /api/math/factorial** — Calcula el factorial de un número
- **POST /api/math/fibonacci** — Genera secuencia de Fibonacci hasta n términos  
- **POST /api/math/mcd** — Calcula el Máximo Común Divisor entre dos números

### Controlador Puzzles (`/api/puzzles`)
- **POST /api/puzzles/change-making** — Calcula cambio óptimo con monedas
- **POST /api/puzzles/towers-of-hanoi** — Resuelve las Torres de Hanoi

Cada endpoint recibe un JSON con los parámetros y devuelve un JSON con el resultado.

## Cómo funciona (arquitectura)

1. **Program.cs** configura la aplicación: registra controladores e inyección de dependencias
2. **Controladores** (`MathController`, `PuzzlesController`) reciben requests HTTP y validan entrada
3. **Servicios** (`MathService`, `PuzzleService`) implementan la lógica recursiva
4. **DTOs** (`MathDtos.cs`, `PuzzleDtos.cs`) definen contratos de entrada y salida
5. La respuesta se serializa a JSON automáticamente

### Inyección de dependencias configurada:
- `IMathService` → `MathService`
- `IPuzzleService` → `PuzzleService`

## Requisitos (desarrollo)

- .NET SDK 9.x instalado (ver `dotnet --version`) — se desarrolló con .NET 9
- Git
- PowerShell (pwsh) o tu terminal preferido
- IDE recomendado: Visual Studio 2022/2023, VS Code o JetBrains Rider

## Pasos para clonar y ejecutar

1. **Clonar el repositorio:**
   ```powershell
   git clone <URL_DEL_REPO>
   cd recursividad.Api
   ```

2. **Restaurar dependencias:**
   ```powershell
   dotnet restore
   ```

3. **Compilar el proyecto:**
   ```powershell
   dotnet build
   ```

4. **Ejecutar la API:**
   ```powershell
   dotnet run
   ```

5. **Acceder a la API:**
   - **HTTPS**: `https://localhost:7297`
   - **HTTP**: `http://localhost:5250`
   - Los puertos están configurados en `Properties/launchSettings.json`

## Configuración del proyecto

- **appsettings.json**: Configuración básica con logging (no requiere modificación)
- **launchSettings.json**: Define puertos `7297` (HTTPS) y `5250` (HTTP) 
- **Variables de entorno**: `ASPNETCORE_ENVIRONMENT=Development` por defecto
- **Sin Swagger/OpenAPI**: El proyecto no tiene Swagger configurado actualmente

## Endpoints y ejemplos

### Factorial
```http
POST https://localhost:7297/api/math/factorial
Content-Type: application/json

{
  "number": 5
}
```
**Respuesta:** `{"result": 120}`

### Fibonacci
```http
POST https://localhost:7297/api/math/fibonacci
Content-Type: application/json

{
  "count": 7
}
```
**Respuesta:** `{"sequence": [0, 1, 1, 2, 3, 5, 8]}`

### Máximo Común Divisor
```http
POST https://localhost:7297/api/math/mcd
Content-Type: application/json

{
  "numberA": 48,
  "numberB": 18
}
```
**Respuesta:** `{"result": 6}`

### Cambio de Monedas
```http
POST https://localhost:7297/api/puzzles/change-making
Content-Type: application/json

{
  "amountDue": 12.50,
  "amountPaid": 20.00
}
```

### Torres de Hanoi
```http
POST https://localhost:7297/api/puzzles/towers-of-hanoi
Content-Type: application/json

{
  "numberOfDisks": 3
}
```

## Cómo continuar el desarrollo

- **Tests**: Actualmente no hay tests. Agregar proyecto de tests con xUnit
- **Validación**: Los controladores tienen manejo básico de excepciones, se puede mejorar
- **Swagger**: Agregar `Swashbuckle.AspNetCore` para documentación automática
- **Logging**: Configurar logging más detallado en `appsettings.json`
- **Límites de recursión**: Agregar validación para evitar stack overflow con números grandes

## Comandos útiles

```powershell
# Restaurar dependencias
dotnet restore

# Compilar
dotnet build

# Ejecutar en modo desarrollo
dotnet run

# Ejecutar con puerto específico
dotnet run --urls "https://localhost:8000"

# Ver información del proyecto
dotnet --info
```

---

**Nota**: Este README refleja la configuración actual del proyecto. Los endpoints están implementados con inyección de dependencias y manejan excepciones básicas.