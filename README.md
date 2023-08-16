# Taller_herramientas_Ricardo_Moreno

## Proyecto de control y migración de PSTs

Este es un extracto del documento que se requiere para la creación y control de los archivos PST.

### Problema
Durante el proyecto de migración de archivos tipo PST hacia la nube, yo Ricardo Moreno, Ingeniero relacionado con esta proyecto, he detectado que los PSTs toman mucho tiempo de carga y generan confusión ya que los nombres que los usuarios denominan a sus archivos es muy genérico y tiende a repertirse en patrones.


### Solución propuesta

Para tal efecto, mi propuesta es renombrar los archivos de manera única, utilizando el siguiente formato:

"smtp" + "_" + "Nombre del PST"

Ejemplo

Castillo.RicardoM@ricardolabs.info_ElProfesorAlfredoEsMuyProfesional.pst

### Arquitectura

Para tal efecto, se requiere:

1.- Servidores Windows con consola de Scripting (mejor conocida como PowerShell ISE).
2.- Servidores de carga Azure tipo Blob
3.- Cuentas de acceso con rol "BlobContributor" o si no es posible, instalación del software AZCopy.exe


### Ligas de Utilidad:

https://learn.microsoft.com/en-us/purview/use-network-upload-to-import-pst-files

https://ricardolabs.sharepoint.com/sites/Tallerdeproductividadbasadaenherramientastecnolgicas


