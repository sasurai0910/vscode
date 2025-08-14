using Microsoft.AspNetCore.Mvc;
namespace MyMvcApp.Controllers;

using MyMvcApp.Data;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly MyDbContext _context;

    public HomeController(ILogger<HomeController> logger, MyDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        GreetingService greetingMessage = new GreetingService();

        ViewData["GreetingMessage"] = greetingMessage.GetGreetingMessage();

        return View();
    }

    /// <summary>
    /// 入力画面へ移る処理
    /// </summary>
    /// <returns></returns>
    public IActionResult Insert()
    {
        return View();
    }

    /// <summary>
    /// 入力画面の確認画面へ進むボタン押下時に呼ばれる処理
    /// </summary>
    /// <param name="input">入力情報</param>
    /// <returns>確認画面</returns>
    [HttpPost]
    public IActionResult Insert(CustomerInput input)
    {
        if (ModelState.IsValid)
        {
            return View("Confirm", input.InputItem);
        }

        // バリデーションエラーがあれば再表示
        return View(input.InputItem);
    }

    /// <summary>
    /// 登録ボタン押下時にDBに値を登録する処理
    /// </summary>
    /// <param name="input">入力情報</param>
    /// <returns>確認画面</returns>
    [HttpPost]
    public IActionResult Confirm(CustomerInput input)
    {
        var entity = new ItemEntity
        {
            Name = model.InputItem
        };
        // データベースに追加
        _context.InputDatas.Add(input);

        // 保存
        _context.SaveChanges();
        // バリデーションエラーがあれば再表示
        return View(input);
    }



    /// <summary>
    /// 確認画面へ遷移
    /// </summary>
    /// <returns></returns>
    public IActionResult Confirm()
    {
        return View();
    }
}
