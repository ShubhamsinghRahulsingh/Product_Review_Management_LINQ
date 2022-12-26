﻿using System;
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
        public void RetrieveAllRecordsAboveRatingThree(List<ProductReview> list)
        {
            var result = this.productReviews.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 3 || x.ProductId == 9));
            PrintList(result.ToList());
        }
        public void CountNoOfReviewsForProductID(List<ProductReview> list)
        {
            var result = this.productReviews.GroupBy(x => x.ProductId);
            foreach (var data in result)
            {
                Console.WriteLine("No Of Reviews For ProductId {0}:{1}",data.Key, data.Count());
                PrintList(data.ToList());
            }
        }
        public void GetParticularFields(List<ProductReview> list)
        {
            var result = this.productReviews.Select(x => new { x.ProductId, x.Rating });
            foreach (var data in result)
            {
                Console.WriteLine("ProductId:"+data.ProductId + " " +"Rating:"+ data.Rating);
            }
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
