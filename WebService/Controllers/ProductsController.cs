using System.Collections.Generic;
using System.Web.Http;
using MyBL;

namespace WebService.Controllers
{
    /// <summary>
    /// Controller for action with Products.
    /// </summary>
    public class ProductsController : ApiController
    {
        /// <summary>
        /// Product Repository.
        /// </summary>
        private readonly ProductRepository productRepository;

        /// <summary>
        /// Parameterfull Constructor.
        /// </summary>
        public ProductsController()
        {
            this.productRepository = new ProductRepository();
        }
        
        /// <summary>
        /// Getter for all Products.
        /// </summary>
        public IEnumerable<Product> Get()
        {
            return this.productRepository.GetAll();
        }

        /// <summary>
        /// Gets the Product by ID.
        /// </summary>
        /// <param name="id">Product's id</param>
        /// <returns>product</returns>
        public Product Get(int id)
        {
            return this.productRepository.GetProductByID(id);
        }

        /// <summary>
        /// Insert new Product.
        /// </summary>
        /// <param name="product">product</param>
        /// <returns>If Product is added returns true else false</returns>
        public bool Post(Product product)
        {
            return this.productRepository.Add(product);
        }

        /// <summary>
        /// Update product.
        /// </summary>
        /// <param name="id">Old product id</param>
        /// <param name="newProduct">new product</param>
        /// <returns>If Product is updated returns true else false</returns>
        public bool Put(int id, Product newProduct)
        {
            return this.productRepository.Update(id, newProduct);
        }

        /// <summary>
        /// Delete Product.
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>If Product is deleted returns true else false</returns>
        public bool Delete(int id)
        {
            return this.productRepository.Delete(id);
        }
    }
}
