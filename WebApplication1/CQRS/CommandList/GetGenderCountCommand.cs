using MyMediator.Interfaces;
using WebApplication1.DB;

namespace WebApplication1.CQRS.CommandList
{
    public class GetGenderCountCommand : IRequest<CountGenders>
    {
        public int Index { get; set; } = 0;

        public class GetGenderCountCommandHandler : IRequestHandler<GetGenderCountCommand, CountGenders>
        {
            private readonly Db131025Context db;
            public GetGenderCountCommandHandler(Db131025Context db)
            {
                this.db = db;
            }

            public async Task<CountGenders> HandleAsync(GetGenderCountCommand request, CancellationToken ct = default)
            {
                CountGenders countGenders = new CountGenders();
                //db.Students.Where(s => s.IdGroup == request.Index && s.Gender == "1").Select(s => );
                    //db.Students.Where(s => s.IdGroup == request.Index).Select
                    //(s => new StudentDTO {Id = s.Id, FirstName = s.FirstName, LastName = s.LastName, Gender = s.Gender, IdGroup = s.IdGroup, Phone = s.Phone });
                return countGenders;
            }
        }
    }
}
