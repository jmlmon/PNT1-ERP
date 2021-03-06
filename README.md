# ERP-B谩sico 馃摉

## Objetivos 馃搵
Desarrollar un sistema de ERP B谩sico para una empresa Pyme, que permita la administraci贸n y uso de recursos en ella. 
De cara a los empleados de RRHH: Empleados, Posiciones, Gerencias, Centros de Costo, etc. 
Utilizar Visual Studio 2019 preferentemente y crear una aplicaci贸n utilizando ASP.NET MVC Core (versi贸n a definir por el docente 3.1 o 6.0).

<hr />

## Enunciado 馃摙
La idea principal de este trabajo pr谩ctico, es que Uds. se comporten como un equipo de desarrollo.
Este documento, les acerca, un equivalente al resultado de una primera entrevista entre el paciente y alguien del equipo, el cual relev贸 e identific贸 la informaci贸n aqu铆 contenida. 
A partir de este momento, deber谩n comprender lo que se est谩 requiriendo y construir dicha aplicaci贸n, 

Deben recopilar todas las dudas que tengan y evacuarlas con su nexo (el docente) de cara al paciente. De esta manera, 茅l nos ayudar谩 a conseguir la informaci贸n ya un poco m谩s procesada. 
Es importante destacar, que este proceso, no debe esperar a ser en clase; es importante, que junten algunas consultas, sea de 铆ndole funcional o t茅cnicas, en lugar de cada consulta enviarla de forma independiente.

Las consultas que sean realizadas por correo deben seguir el siguiente formato:

Subject: [CURSO-<X> GRUPO-<XX>] <Proyecto XXX>

Body: 

1.<xxxxxxxx>

2.< xxxxxxxx>


# Ejemplo
**Subject:** [CURSO-A GRUPO-05] ERP

**Body:**

1.La relaci贸n del Empleado con Posici贸n es 1:1 o 1:N?

2.Est谩 bien que encaremos la validaci贸n de EmpleadoActivo para los empleados, como con una propiedad booleana?

### Proceso de ejecuci贸n en alto nivel
 - Crear un nuevo proyecto en [visual studio](https://visualstudio.microsoft.com/en/vs/).
 - Adicionar todos los modelos dentro de la carpeta Models cada uno en un archivo separado.
 - Especificar todas las restricciones y validaciones solicitadas a cada una de las entidades. [DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1).
 - Crear las relaciones entre las entidades
 - Crear una carpeta Data que dentro tendr谩 al menos la clase que representar谩 el contexto de la base de datos DbContext. 
 - Crear el DbContext utilizando base de datos en memoria (con fines de testing inicial). [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-3.1), [Database In-Memory](https://docs.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=vs).
 - Agregar los DbSet para cada una de las entidades en el DbContext.
 - Crear el Scaffolding para permitir los CRUD de las entidades al menos solicitadas en el enunciado.
 - Aplicar las adecuaciones y validaciones necesarias en los controladores.  
 - Realizar un sistema de login con al menos los roles equivalentes a <Usuario Cliente> y <Usuario Administrador> (o con permisos elevados).
 - Si el proyecto lo requiere, generar el proceso de registraci贸n. 
 - Un administrador podr谩 realizar todas tareas que impliquen interacci贸n del lado del negocio (ABM "Alta-Baja-Modificaci贸n" de las entidades del sistema y configuraciones en caso de ser necesarias).
 - El <Usuario Cliente> s贸lo podr谩 tomar acci贸n en el sistema, en base al rol que tiene.
 - Realizar todos los ajustes necesarios en los modelos y/o funcionalidades.
 - Realizar los ajustes requeridos del lado de los permisos.
 - Todo lo referido a la presentaci贸n de la aplicai贸n (cuestiones visuales).
 
<hr />

## Entidades 馃搫

- Usuario
- Empleado
- Telefono
- TipoTelefono
- Foto
- Posici贸n
- Gerencia
- CentroDeCosto
- Gastos
- Empresa


`Importante: Todas las entidades deben tener su identificador unico. Id o <ClassNameId>`

`
Las propiedades descriptas a continuaci贸n, son las minimas que deben tener las entidades. Uds. pueden agregar las que consideren necesarias.
De la misma manera Uds. deben definir los tipos de datos asociados a cada una de ellas, como as铆 tambi茅n las restricciones.
`

**Usuario**
```
- Nombre
- Email
- FechaAlta
- Password
```

**Empleado**
```
- Nombre
- Apellido
- DNI
- Telefonos
- Direccion
- FechaAlta
- Email 
- ObraSocial
- Legajo
- EmpleadoActivo
- Posicion
- Foto
```
**Telefono**
```
- Numero
- TipoTelefono
```

**TipoTelefono**
```
- Nombre
```

**Imagen**
```
- Nombre
- Path
```

**Posicion**
```
- Nombre
- Descipcion
- Sueldo
- Empleado
- Responsable(Jefe)
- Gerencia
```

**Gerencia**
```
- Nombre
- EsGerenciaGeneral
- Direccion(Gerencia)
- Responsable(Posicion)
- Posiciones
- Gerencias
- Empresa
```

**CentroDeCosto**
```
- Nombre
- MontoMaximo
- Gastos
```

**Gastos**
```
- Descipcion
- CentroDeCosto
- Empleado
- Monto
- Fecha
```

**Empresa**
```
- Nombre
- Rubro
- Logo
- Direccion
- TelefonoContacto
- EmailContacto
	- Gerencias 馃煝  鉁旓笍 
```

**NOTA:** aqu铆 un link para refrescar el uso de los [Data annotations](https://www.c-sharpcorner.com/UploadFile/af66b7/data-annotations-for-mvc/).

<hr />

## Caracteristicas y Funcionalidades 鈱笍
`Todas las entidades, deben tener implementado su correspondiente ABM, a menos que sea implicito el no tener que soportar alguna de estas acciones.`

`IMPORTANTE: Solo empleados de RRHH pueden realizar modificaciones en la nomina de Empleados, Pero todos pueden ver informaci贸n general de la Empresa.`

**Usuario**
- Los Empleados no pueden auto-registrarse.

**Empleado**
- Los empleados, deben ser agregados por otro Empleado.
	- Al momento, del alta del empleado, se le definir谩 un username y password definida automaticamente por el sistema con el DNI.
    - Tambi茅n se le asignar谩 a estas cuentas el rol de empleado y adicionalmente el de RRHH si corresponde.
- Un empleado puede consultar todos sus datos y actualizar solo sus telefonos y foto.
- Puede navegar el organigrama. Para detalle, de funcionalidad, ver Organigrama. 
- Puede actualizar datos de contacto, como sus telefonos, direcci贸n y foto.. Pero no puede modificar su DNI, Nombre, Apellido, etc.
- Pueden Imputar gastos a su Centro de Costo.
- Cada empleado puede listar sus gastos en orden decreciente, por fecha.

**Organigrama**
- La visualizaci贸n del Organigrama, siempre estar谩 disponible para cualquier Empleado de la compa帽ia. 
- Se parte por la Gerencia General (solo puede existir una), se visualiza el Responsable de la misma.
- Al hacer click, en ella, se visualizar谩, el siguiente nivel de jerarquico, con cada una de las gerencias que la componga y sus correspondientes responsables.
    - En el caso de ser una Gerencia, que no tiene subGerencias, mostrar todos los empleados que la componen (Solo Apellido y Nombre), en formado de lista, con orden Ascendente con la condici贸n Apellido y Nombre.
    - Se podr谩 hacer click en cada empleado, para visualizar una tarjeta de contacto.
    - La tarjeta de contacto tendr谩: Apellido, Nombre, Nombre de la posici贸n, Telefonos e Email.
    Importante: Solo se visualizar谩n empleados que est茅n activos en nomina. 

**Empleado de RRHH**
- Un empleado de RRHH, puede crear, modificar todos los datos de los Empresa, otros empleados, Gerencias, Posiciones, etc.. Tiene control total de la informaci贸n contenida en el sistema.
    - No puede eliminar Empleados, pero si puede deshabilitarlos, para indicar que no son empleados actuales de nomina.
- El Empleado puede listar todos los empleado, y por cada uno, ver en sus detalles, como as铆 tambi茅n, realizar modificaciones. 
- Puede realizar un listado de empleados, con sueldo en forma decreciente por el concepto de sueldos y luego Creciente para Apellido y Nombre. 
    - Se debe incluir Sueldo,Apellido, Nombre, Nombre de la posici贸n.
- No puede modificar ni eliminar un Gasto de cualquier Empleado.
- Puede listar todos los gastos de todos los empleados en forma decreciente por fecha y ordenados de manera creciente por Apellido y Nombre. Se debe incluir la informaci贸n de que gerencia pertenece.
- Listar los montos totales de gastos por cada gerencia, idependientemente de si es una Gerencia o SubGerencia. (Orden decreciente por monto)

**Posici贸n**
- La posici贸n, es la que dar谩 la relaci贸n entre un Empleado y la Gerencia a la cual pertenece.
- La posici贸n, puede o no tener empleados actualmente ocupandola. Ej. La posici贸n de gerente de IT, puede estar disponible, sin un empleado que la est茅 ocupando.
- El Responsable de dicha posici贸n, es otra posici贸n, no es un empleado. En todo caso, tiene una Posici贸n de la cual depende, y esa otra posici贸n tiene un Empleado o no que est谩 ocupando esa posici贸n.
- La posici贸n es la que tiene un sueldo designado, no es el empleado.
- Pertenece a una Gerencia.


**Centro de Costo**
- El centro de Costos puede ser asociado a solo una gerencia de cualquier nivel.
- Los empleados, solo pueden imputar gastos al centro de costo que tenga la gerencia a la cual pertenecen de forma directa.
- Se pueden imputar gastos al centro de costo, dejando registro de cual es el empleado que lo est谩 imputando, siempre y cuando, no supere el monto maximo del Centro de Costo.


**Aplicaci贸n General**
- Informaci贸n institucional, en base a la informaci贸n de la Empresa, con su respectiva imagen (Logo)
- No existe un limite para las posiciones dependientes. Ejemplo, puede existir 10 o 1000 posiciones que dependan de una posici贸n gerencial. En otras palabras, un Gerente asignado a una posici贸n de Gerente de IT, puede tener 1, 10 o 1000 posiciones de IT general, que dependen de ella. 
- Los accesos a las funcionalidades y/o capacidades, debe estar basada en los roles que tenga cada individuo.


