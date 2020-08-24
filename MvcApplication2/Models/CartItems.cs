using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;


namespace MvcApplication2.Models
{
    public class CartItems 
    {
       
         
            [Display(Name = "A")]
            public string AItem { get; set; }

            [Required]
            [Display(Name = "AQuantity")]
            public Int32 AQuantity { get; set; }

         
            [Display(Name = "B")]
            public string BItem { get; set; }

            [Required]
            [Display(Name = "BQuantity")]
            public Int32 BQuantity { get; set; }
           

            [Display(Name = "C")]
            public string CItem { get; set; }

            [Required]
            [Display(Name = "CQuantity")]
            public Int32 CQuantity { get; set; }

          
            [Display(Name = "D")]
            public string DItem { get; set; }

            [Required]
            [Display(Name = "DQuantity")]
            public Int32 DQuantity { get; set; }

        
    
            public string Price { get; set; }


            public string OriginalPrice { get; set; }

         
           
            public string Discount { get; set; }
         
           
            public string FinalPrice { get; set; }
        
        



    }
}
