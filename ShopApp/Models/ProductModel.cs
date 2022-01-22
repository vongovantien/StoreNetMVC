using Microsoft.AspNetCore.Http;
using ShopApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Mã sản phẩm")]
        public int ProductId { get; set; }
        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Nhập tên sản phẩm")]
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Loại sản phẩm")]
        public virtual Category Category { get; set; }
        [Display(Name = "Nhà cung cấp")]
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [Display(Name = "Choose the cover image")]
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
