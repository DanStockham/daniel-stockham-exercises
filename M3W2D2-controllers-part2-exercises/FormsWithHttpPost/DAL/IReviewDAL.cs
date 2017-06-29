using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsWithHttpPost.DAL
{
    public interface IReviewDAL
    {
        List<ReviewModel> GetAllReviews();
        bool SaveReview(ReviewModel newReview);
    }
}
