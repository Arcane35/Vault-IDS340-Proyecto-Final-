*Jean Michel Boucher García (cod. 1101604)*

Este repositorio corresponde al proyecto final de las materias **IDS340 e IDS340L (Desarrollo de Software I)** impartidas en el Instituto Tecnológico de Santo Domingo (**INTEC**), por el profesor **Lorenzo Antonio Martínez Lebrón**.

# Información General

**Vault** es un programa de administración de inventario, hecho en Windows Forms, el cual utiliza el paquete SQLite para crear una base de datos localmente adentro del folder del proyecto (llamado *Database.db*). Contiene cuatro módulos (divididas en pestañas diferentes), las cuales le permiten al usuario realizar las siguientes funciones:
-	**Gestion de Productos:** Esta pestaña visualiza todos los Productos que estan actualmente guardadas adentro del inventario. Permite agregar, editar o eliminar cualquier producto que esta adentro del inventario actualmente.
-	**Gestion de Categorías:** Esta pestaña visualiza todas las Categorías que estan actualmente guardadas adentro de la base de datos. Permite agregar, editar o eliminar categorías.
-	**Gestion de Proveedores:** Esta pestaña visualiza todos las Proveedores que estan actualmente guardadas adentro de la base de datos. Permite agregar, editar o eliminar proveedores.
-	**Consultas y Reportes:** Esta pestaña visualiza nuevamente todos los Productos del inventario. El usuario podrá filtrar los Productos por Categoría y Proveedor, además de también poder ver cuales Productos adentro del inventario tienen baja disponibilidad.

Además de las funcionalidades básicas de agregar, editar y eliminar productos, categorías o proveedores, Vault también contiene funcionalidades adicionales para mejorar la experiencia de administración para el usuario:

-	**Message Boxes de Advertencia:** Todos los controles del programa le dan un aviso al usuario en caso de que su accion haya sido exitosa o no.
-	**Auto relleno de Seleccion:** Hacer click a un elemento adentro de la base de datos hace que se auto-rellene las cajas de texto con todos los detalles del elemento seleccionado. Esto permite una edición o eliminacion de entradas mas eficientemente (ya que remueve la necesidad de tener que escribir todos los detalles de dicha entrada antes e poder editarla o eliminarla).
-	**Generación de Reporte en .CSV:** Adentro de la pestaña de Consultas y Reportes existe un botón que permite generar un reporte de los Productos que actualmente tienen baja disponibilidad. Este reporte se generará en la carpeta “Documents” del usuario.

Debido a que el programa fue diseñada para que funcionara adentro de una sola pestaña de Forms, todo el codigo que contiene los metodos y funcionalidad del programa esta contenido adentro de un solo archivo .cs (*FormPrincipal.cs*). 
El archivo *Database.cs* contiene los metodos que permiten la comunacion de los controles del Form a la base de datos (ademas de tambien contener el metodo que re-crea la base de datos, en caso de que sea eliminada).

El codigo contenido en ambos archivos esta documentado con comentarios que detallan el funcionamiento de los metodos que tienen.

Este programa viene con entradas pre-ingresadas adentro de la base de datos, para mejor demostrar sus funciones. Todas pueden ser modificadas si el usuario desea (ya sea por este mismo programa o mediante DB Browser).



