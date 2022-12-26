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
        public void PrintList(List<ProductReview> list)
        {
            foreach (ProductReview productReview in list)
            {
                Console.WriteLine("ProductID:" + productReview.ProductId + "  UserID:" + productReview.UserId + "  Rating:" + productReview.Rating + "  Review:" + productReview.Review + "     ISLIKE:" + productReview.IsLike);
            }
        }
    }
}
