using AutoMapper;
using DocTruyen.Service.DTOs.Comment;
using DocTruyen.Service.DTOs.Reply;
using DocTruyen.Service.DTOs.User;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers.ViewComponents
{
    public class ListCommentViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ListCommentViewComponent(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int novelId)
        {
            var comments = await _unitOfWork.Comments.GetAllAsync(c => c.NovelId == novelId, null, new List<string> { "User" });
            if (comments == null) return View();
            var cmtParrents = (from cmt in comments
                               where cmt.ParrentId == null
                               select cmt).ToList();
            var cmtChilds = (from cmt in comments
                             where cmt.ParrentId != null
                             select cmt).ToList();

            var commentsViews = new List<CommentViewDTO>();

            foreach (var cmt in cmtParrents)
            {
                var cmtView = new CommentViewDTO
                {
                    Id = cmt.Id,
                    Text = cmt.Text,
                    User = _mapper.Map<UserDTO>(cmt.User),
                    CreatedDate = cmt.CreatedDate
                };

                if (cmtChilds != null)
                {
                    var replies = new List<ReplyViewDTO>();
                    foreach (var child in cmtChilds)
                    {
                        if (child.ParrentId == cmt.Id)
                        {
                            var reply = new ReplyViewDTO
                            {
                                Id = child.Id,
                                Text = child.Text,
                                ParrentId = child.ParrentId,
                                User = _mapper.Map<UserDTO>(child.User),
                                CreatedDate = child.CreatedDate
                            };
                            if (reply != null)
                                replies.Add(reply);
                        }
                    }
                    if (replies != null)
                        cmtView.Replies = replies;
                }
                if (cmtView != null)
                    commentsViews.Add(cmtView);
            }
            return View(commentsViews);
        }
    }
}

