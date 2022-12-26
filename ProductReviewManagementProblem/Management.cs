using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProblem
{
    public class Management
    {
        List<ProductReview> productReviews = new List<ProductReview>();
        public void AddProductReviews(List<ProductReview> list)
        {
            this.productReviews = list;
            Console.WriteLine("Reviews Added Successfully to the list");
        }
        public void RetrieveTopRecords(List<ProductReview> list)
        {
            //Standard Query Operators in Method Syntax(Method1)
            var result = this.productReviews.OrderByDescending(x => x.Rating).Take(3);
            PrintList(result.ToList());

           // //Standard Query Operators in Query Syntax(Method2)
            //var query = (from products in productReviews
            //             orderby products.Rating descending
            //             select products).Take(3);
            //             PrintList(query.ToList());
        }
        public void PrintList(List<ProductReview> list)
        {
            foreach (ProductReview productReview in list)
            {
                Console.WriteLine("ProductID:" + productReview.ProductId + "  UserID:" + productReview.UserId + "  Rating:" + productReview.Rating + "  Review:" + productReview.Review + "     ISLIKE:" + productReview.IsLike);
            }
        }
    }
}
