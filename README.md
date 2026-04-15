# VotacionesAPI

Sistema de votaciones simple con backend en ASP.NET Core y frontend en React.

## Características
- Registrar votos con nombre de candidato y cédula
- Listar todos los votos registrados
- API RESTful con Entity Framework y SQLite
- Frontend React con consumo de API vía Axios

## Estructura del proyecto

```
VotacionesAPI/
├── Controllers/
│   └── VotosController.cs      # Controlador API para votos
├── Data/
│   └── AppDbContext.cs        # Contexto de base de datos
├── Migrations/                # Migraciones de Entity Framework
├── Models/
│   └── Voto.cs                # Modelo de datos Voto
├── Properties/
│   └── launchSettings.json    # Configuración de puertos
├── votaciones-fronted/
│   ├── src/
│   │   ├── App.js             # Componente principal React
│   │   └── services/
│   │       └── api.js         # Funciones para consumir la API
│   └── public/
│       └── index.html         # HTML base
├── appsettings.json           # Configuración general
├── Program.cs                 # Configuración de la app ASP.NET
└── VotacionesAPI.csproj       # Proyecto principal
```

## Instalación y ejecución

### Backend (.NET)
1. Restaurar dependencias:
   ```
   dotnet restore
   ```
2. Crear migraciones y actualizar la base de datos:
   ```
   dotnet ef database update
   ```
3. Ejecutar el backend:
   ```
   dotnet run
   ```
   El API estará disponible en `http://localhost:5186/api/votos`

### Frontend (React)
1. Instalar dependencias:
   ```
   cd votaciones-fronted
   npm install
   ```
2. Ejecutar el frontend:
   ```
   npm start
   ```
   La app estará disponible en `http://localhost:3000`

## Uso
- Ingresa el nombre del candidato y la cédula en el formulario.
- Haz clic en "Votar" para registrar el voto.
- La lista mostrará todos los votos registrados.

## Autor
- Desarrollado por jesus
