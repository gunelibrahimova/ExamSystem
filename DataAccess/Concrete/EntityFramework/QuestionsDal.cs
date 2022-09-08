using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class QuestionsDal : EFEntityRepositoryBase<ExamSystemDbContext, Question>, IQuestionDal
    {
        public List<Question> GetAll()
        {
            using ExamSystemDbContext context = new ExamSystemDbContext();

            return context.Question.ToList(); //orderby
        }

        public Question GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
