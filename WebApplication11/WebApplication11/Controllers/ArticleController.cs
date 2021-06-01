using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Clients;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {


        private readonly ILogger<ArticleController> _logger;
        private readonly apiClient _apiClient;

        public ArticleController(ILogger<ArticleController> logger, apiClient apclient)
        {
            _logger = logger;
            _apiClient = apclient;
        }

        [HttpGet("mostpopular")]
        public async Task<IEnumerable<Response>> GetArticles()
        {
            var articles = await _apiClient.GetArticles();
            var result = articles.Results.Select(a => new Response
            {
                Url = a.Url,
                Published_date = a.Published_date,
                Section = a.Section,
                Title = a.Title
            });
            return result;
        }


        [HttpGet("books")]
        public async Task<IEnumerable<Response3>> GetArticles3()
        {
            var articles = await _apiClient.GetArticles3();
            var result = articles.results.books.Select(a => new Response3
            {
                description = a.description,
                title = a.title,
                author = a.author,
                book_image = a.book_image
            });
            return result;
        }


        [HttpGet("reviewfilms")]
        public async Task<IEnumerable<Response4>> GetArticles4([FromQuery] Resp4 parameters)
        {
            var articles = await _apiClient.GetArticles4(parameters.Name);
            var result = articles.results.Select(a => new Response4
            {
                display_title = a.display_title,
                link = a.link
            });
            return result;
        }


        [HttpGet("topstories")]
        public async Task<IEnumerable<Response6>> GetArticles6([FromQuery] Resp6 parameters)
        {
            var articles = await _apiClient.GetArticles6(parameters.Name);
            var result = articles.Results.Select(a => new Response6
            {
                Url = a.Url,
                Published_date = a.Published_date,
                Section = a.Section,
                Title = a.Title
            });
            return result;
        }


        [HttpGet("comments")]
        public async Task<IEnumerable<Response7>> GetArticles7([FromQuery] Resp7 parameters)
        {
            var articles = await _apiClient.GetArticles7(parameters.Name);
            var result = articles.results.comments.Select(a => new Response7
            {
                userDisplayName = a.userDisplayName,
                userLocation = a.userLocation,
                commentBody = a.commentBody
            });
            return result;
        }

    }
}

