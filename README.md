# WhattsChallenge

readme

# 💳 Debt History Service

Microservicio desarrollado en .NET CORE 9 que expone información clave sobre el historial de deudas de un usuario, como parte del ecosistema de crédito de VEMO.

## 🚀 Descripción

Este microservicio conecta con servicios externos para obtener el historial de transacciones de un usuario y analiza:

- 📉 **Número de veces que el usuario ha caído en saldo negativo (deuda).**
- ⏱ **Tiempo promedio de recuperación de la deuda (en días).**

- **************************Aunque realmente solo se agrego la consulta del wallet por email

---

## ⚙️ Endpoints

### `GET /api/User/GetWalletByEmail?email=usuario
**Parámetro requerido:**

- `email` (string): Correo del usuario para identificar su wallet.

**Respuesta:**
```json
{
    "data": {
        "idWallet": 1,
        "aliasWallet": "Fake",
        "email": "sdas@live.com.mx"
    },
    "isSuccess": true,
    "message": "Ok",
    "statusCode": 200,
    "stringCode": null,
    "exception": null,
    "errorCode": 0
}
🧱 Arquitectura
El servicio sigue una arquitectura limpia N Capas o hexagonal:

Controllers: Manejo de peticiones HTTP.

Services: Lógica de negocio (análisis de deudas).
DTOs / Models: Control de datos de entrada/salida.

Para ejecutar 
🐳 Docker
Dockerfile
Incluido en la raíz del proyecto para generar una imagen del microservicio.

Docker Compose
Incluye un docker-compose.yml para ejecutar fácilmente:

bash
Copy
Edit
docker-compose up --build
Servicio accesible en: http://localhost:5000/swagger

🔒 Seguridad
Asegura que los parámetros de entrada estén validados (como el email).

El acceso a los endpoints externos puede ampliarse con autenticación por api key.

📦 Instalación local
Requisitos
.NET 7 SDK

Docker

Levantar el proyecto
bash
Copy
Edit
dotnet run
Luego accede a: http://localhost:5000/swagger


Utiliza Swagger (Swashbuckle) para documentación automática.

La lógica de deuda es testeable de forma aislada.

🧠 Decisiones de diseño
Se separó la lógica de negocio de la capa de red/controlador para mejorar la mantenibilidad y testabilidad.

Se evita el uso de ORM o base de datos, ya que todo se basa en dummy.
