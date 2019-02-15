Comandos para conexión contra MySQL:

```
dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.13
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef dbcontext scaffold "server=server;port=3306;user=usuario;password=passsegura;database=nombre_db" MySql.Data.EntityFrameworkCore -o DAO -f
```

Deploy en Azure:
App services => Agregar
Setear nombre y grupo de recursos => Crear
Dentro del app service => Centros de implementación => Seleccionar método (GitHub en nuestro caso, configurar user y pass si es necesario)
Definir servidor de compilación => Finalizar
