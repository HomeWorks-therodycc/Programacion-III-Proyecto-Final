### link a la pagina
 [sistema-final.herokuapp.com](https://sistema-final.herokuapp.com)

---

# Sistema de Gestión de Alquileres de Vehículos.

El sistema debe permitir que una institución tenga diferentes vehículos, y pueda gestionar los alquileres de los mismos.

**Los vehículos pueden ser**

- motocicletas
- carros
- camionetas
- camiones
- barcos
- aviones
- naves de tesla (space X)
- Etc

> **NOTA** Este sera el campo categoria

## **El sistema debe tener los siguientes módulos:**

## Gestión de vehículos

**Se podrán**

- agregar
- editar
- deshabilitar los vehículos que existen disponibles para alquilar.

  **Deben contar con al menos las siguientes informaciones del vehículo.**

1. Marca
2. Modelo
3. Año
4. Color
5. Precio por día. (en pesos dominicanos)
6. Tipo (Carro, Camioneta, Nave, etc) se selecciona de una lista.
7. Capacidad de carga (Kg)
8. Pasajeros.
9. Matricula.
10. Nro Seguro.
11. Foto (una fotografía del mismo)
12. Ubicación (latitud y longitud)

## Gestión de Clientes.

**Se podrán**

- agregar
- editar
- deshabilitar los clientes que alquilan.

**Los campos requerido para el mismo son:**

1. Cedula
2. Nombre
3. Apellido
4. Correo
5. Licencia
6. Nacionalidad
7. Tipo de Sangre
8. Foto de la persona
9. Foto de la licencia

## Gestión de reservas:

En este módulo podremos asignar un cliente a un vehículo en una fecha establecida. La fecha puede ser futura.

1. Seleccionar un vehículo.
2. Cliente.
3. Fecha inicio
4. Fecha de fin.

Luego de esto el sistema verificará que el vehículo está disponible antes de grabar en la fecha elegida, va a crear una factura a nombre del cliente con los datos del vehiculo, desde hasta y el monto a pagar por el mismo..

## Módulo de cobros.

Se van a visualizar todas las facturas generadas a través del sistema de reservas, se podrán registrar como pagadas, cuando se reciba el dinero. Se puede cobrar, la totalidad o una parte de la factura.

## Reportes: Tendremos los siguientes reportes:

- **Listado de vehículos**

disponible en x rango de fecha. Mostrará el listado de los vehículos disponibles en un rango de fecha determinado. Fecha de inicio y fecha final. Mostrara foto, tipo, marca, modelo, color y año

- **Listado de beneficios**

por vehículos. Va a mostrar un listado de todos los vehículos, la cantidad de veces que se han reservado cada uno, y la cantidad de dinero que se ha facturado gracias a ese vehículo.

- **Clientes que deben**.

Aparecerá un listado de los clientes que deben, cedula, nombre, apellido y monto.

- **Ver vehículos en Mapa**

Aquí aparecerán todos los vehículos en un mapa, y podremos dar click para visualizar una ventana flotante con los datos del vehículo: Foto, Marca, Modelo, Año, Color, Y las próxima 3 citas programadas si los tiene.

Para ingresar al sistema, se necesita un usuario y clave. Debe tener un módulo de administración de usuarios.

> Esta práctica debe ser subida a un hosting para ser probada el ultimo dia de clases. Cada grupo debe estar presente al momento de la entrega y revisión de su proyecto. El maestro tiene el compromiso de darle su nota total, de manera individual una vez corregido el proyecto
