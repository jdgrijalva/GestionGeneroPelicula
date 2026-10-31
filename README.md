# GestionGeneroPelicula

## Nombre del sistema
Gestion Genero Pelicula

## Nombre de los integrantes
Joustin Damián Grijalva Mármol
William Oswaldo Villasis Sanango
Cristina Alexandra Guamán Ortega
Wendy Nayeli Bazan Aguayo


## Entidades desarrolladas
Fase 1 -> Joustin Grijalva
Fase 2 -> Cristina Alexandra Guamán Ortega
Fase 3 -> William Oswaldo Villasis Sanango y Wendy Nayeli Bazan Aguayo


## Pasos de ejecución
La cadena de conexión es la siguiente:
1. Clonar el repositorio
2. Confirmar que la configuracion de sqlserver sea compatible con la cadena de conexión que ve a continuación:
"ConnectionStrings": {
  "GestionGeneroPeliculaContext": "Server=localhost\\SQLEXPRESS;Database=GestionGeneroPeliculaContext;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True",
  "Gesti\u00F3nGeneroPeliculaContext": "Server=(localdb)\\mssqllocaldb;Database=Gesti\u00F3nGeneroPeliculaContext;Trusted_Connection=True;MultipleActiveResultSets=true"
}
3. Se debe escribir los siguientes comandos: add-migration (nombre de la migración) y update-database para evitar problemas al momento de crear la base de datos y usar las funciones CRUD
