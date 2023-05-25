using pjPrueba.Data;
using pjPrueba.Models;

using (var context = new Context())
{

    Details detail = new Details();
    detail.ProductWeight = 55;
    detail.ProductSection = "Carnes";

    // Establecer relación entre Details y Products
    Products product = new Products();
    product.ProductName = "Guisantes congelados";
    product.ProductTypeID = detail.ProductTypeID; // Asignar la misma clave foránea
    product.Details = detail; // Establecer la propiedad de navegación

    // Agregar los objetos a la base de datos y guardar los cambios
    context.Details.Add(detail);
    context.Products.Add(product);
    context.SaveChanges();

}
