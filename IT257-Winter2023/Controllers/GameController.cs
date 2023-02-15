using System;
using IT257_Winter2023.Models.Games;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using IT257_Winter2023.Models;

public class GameController : Controller
{
	private IGameRepository repository;

	public GameController(IGameRepository repo)
	{
		repository = repo;
	}

	public ViewResult List() => View(repository.Games);

	public ViewResult Index()
	{
		int id;
		int.TryParse(RouteData.Values["id"].ToString(), out id);
		GameModel game = repository.Games.Where(g => g.Id == id).FirstOrDefault();
		return View(game);
	}
}
