https://localhost:7105/swagger/index.html
link sobre la agenda creada 

# Agenda API

API REST desarrollada en **C#** usando **ASP.NET Core** y **Entity Framework Core** para gestionar una agenda de contactos en **SQL Server**.  
Permite realizar operaciones CRUD (Crear, Leer, Actualizar y Borrar) sobre los registros de la agenda.

## Entidad Agenda

Cada registro de la agenda contiene las siguientes propiedades:

| Propiedad   | Tipo       |
|------------|------------|
| Id         | int        |
| Matricula  | string     |
| Nombre     | string     |
| Apellido   | string     |
| Dirección  | string     |
| Teléfono   | string     |
| Carrera    | string     |
| Universidad| string     |

**Ejemplo de JSON de un registro:**

```json
{
  "id": 1,
  "matricula": "21-SISN-6-028",
  "nombre": "Diana",
  "apellido": "Encarnación",
  "direccion": "Santo Domingo Norte",
  "telefono": "8292917261",
  "carrera": "Ingeniería en Software",
  "universidad": "O&M"
}
