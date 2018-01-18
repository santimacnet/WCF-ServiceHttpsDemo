# WCF-ServiceHttpsDemo

Servicio WCF que utiliza un certificado self-signed en servidor IIS y un cliente WCF anómimo que consume los datos mediante Https usando la capa de transporte y confia en el certificado del servidor.

Para completar esta demo se necesitan realizar algunos pasos:

### Configurar Servidor IIS con Certificado Self-signed
https://docs.microsoft.com/es-es/dotnet/framework/wcf/feature-details/how-to-configure-an-iis-hosted-wcf-service-with-ssl

### Instalar un Servicio WCF en un servidor IIS
https://msdn.microsoft.com/es-es/library/ms733766(v=vs.110).aspx

### Configurar el Cliente WCF anónimo
https://docs.microsoft.com/es-es/dotnet/framework/wcf/feature-details/transport-security-with-an-anonymous-client

### Windows Certificate Store
 
Otra posibilidad seria usando Windows Certificate Store y configurar el cliente, pero es un escenario más complejo y requiere una serie de consideraciones como:

- El cliente WCF debe tener acceso a la clave privada para poder autenticarse con el servicio.
- El cliente WCF debe tener acceso a la clave pública del servicio para autenticar el servicio.
- El cliente  WCF debe implementar una validación de certificado de servicio personalizado, ya que no puede confiar en la validación incorporada.
- Opcionalmente, el cliente de WCF debe tener acceso al certificado del emisor del servicio (clave pública CA) para validar la cadena de certificados del servicio.

### Nota Importante

En el ejemplo que encontrais aquí, nos conectamos al servicio Https sin usar el Windows Certificate Store, confiando en el certificado del servidor y no necesitamos ningún .cer o .pfx

Para escenarios más complejos con WCF, consultar la documentación oficial: 
https://docs.microsoft.com/es-es/dotnet/framework/wcf/feature-details/common-security-scenarios
