using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsWithHttpPost.Models;
using FormsWithHttpPost.DAL;
using System.Collections.Generic;
using System.Transactions;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace FormsWithHttpPost.Tests.DAL
{
    [TestClass]
    public class ReviewDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = squirrels; Integrated Security = True";
        private int reviewCount = 0;


        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM reviews;", connection);
                reviewCount = (int) cmd.ExecuteScalar();
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void GetAllPostsTest()
        {
            ReviewSqlDAL reviewDal = new ReviewSqlDAL(connectionString);

            List<ReviewModel> reviews = reviewDal.GetAllReviews();

            Assert.IsNotNull(reviews);
            Assert.AreEqual(reviewCount, reviews.Count);
        }

        [TestMethod]
        public void SaveNewPostTest()
        {
            ReviewSqlDAL reviewDal = new ReviewSqlDAL(connectionString);

            ReviewModel review = new ReviewModel
            {
                Id = 10,
                Username = "ET",
                Rating = 5,
                Title = "test test test test",
                Message = "test test test test",
                ReviewDate = DateTime.UtcNow
            };

            bool didWork = reviewDal.SaveReview(review);

            Assert.AreEqual(true, didWork);
        }
    }
}
