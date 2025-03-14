using Raylib_cs;

class RockPaperScissor
{
  enum EntityType
  {
    Rock,
    Paper,
    Scissor
  }

  struct Entity
  {
    public const float Size = 30;
    public EntityType Type;
    public float PosX, PosY;
    public float VelX, VelY;
    public bool IsAlive;

    public bool IsDefeatedBy(EntityType type)
    {
      switch (Type)
      {
        case EntityType.Rock: return type == EntityType.Paper;
        case EntityType.Paper: return type == EntityType.Scissor;
        case EntityType.Scissor: return type == EntityType.Rock;
        default: return false;
      }
    }
  }

  public static void Main(string[] args)
  {
    var WindowWidth = 800;
    var WindowHeight = 800;
    Raylib.InitWindow(WindowWidth, WindowHeight, "Rock Paper Scissor");
    Raylib.SetTargetFPS(60);

    var entities = new List<Entity>();
    var allTypes = new[] { EntityType.Rock, EntityType.Paper, EntityType.Scissor };
    for (var iType = 0; iType < allTypes.Length; iType++)
    {
      var typeAngle = iType * 2 * MathF.PI / allTypes.Length;
      var cx = WindowWidth / 2 + MathF.Cos(typeAngle) * WindowWidth / 4;
      var cy = WindowHeight / 2 + MathF.Sin(typeAngle) * WindowHeight / 4;
      for (var i = 0; i < 30; i++)
      {
        var angle = (float)Random.Shared.NextSingle() * 2 * MathF.PI;
        var radius = (float)Random.Shared.NextSingle() * WindowWidth / 10;
        var x = cx + MathF.Cos(angle) * radius;
        var y = cy + MathF.Sin(angle) * radius;

        var vel_angle = (float)Random.Shared.NextSingle() * 2 * MathF.PI;
        var vel = 100;
        entities.Add(new Entity()
        {
          Type = allTypes[iType],
          PosX = x,
          PosY = y,
          VelX = MathF.Cos(vel_angle) * vel,
          VelY = MathF.Sin(vel_angle) * vel,
          IsAlive = true
        });
      }
    }

    while (!Raylib.WindowShouldClose())
    {
      Raylib.BeginDrawing();
      Raylib.ClearBackground(Color.White);

      //Raylib.DrawText("Congrats! You created your first window!", 190, 200, 20, Color.LightGray);
      Raylib.DrawText((1 / Raylib.GetFrameTime()).ToString(), 0, 0, 20, Color.Black);

      var scaledpi = Raylib.GetWindowScaleDPI();

      // Aggiorna posizioni in base alla velocità
      var dt = Raylib.GetFrameTime();
      for (var i = 0; i < entities.Count; i++)
      {
        var entity = entities[i];
        entity.PosX += entity.VelX * dt;
        entity.PosY += entity.VelY * dt;
        if (entity.PosX < 0) { entity.PosX = -entity.PosX; entity.VelX = -entity.VelX; }
        if (entity.PosX >= WindowWidth) { entity.PosX = 2 * WindowWidth - entity.PosX; entity.VelX = -entity.VelX; }
        if (entity.PosY < 0) { entity.PosY = -entity.PosY; entity.VelY = -entity.VelY; }
        if (entity.PosY >= WindowHeight) { entity.PosY = 2 * WindowHeight - entity.PosY; entity.VelY = -entity.VelY; }
        entities[i] = entity;
      }

      // Verifica collisioni
      for (var i = 0; i < entities.Count; i++)
      {
        var entity_i = entities[i];
        for (var j = i + 1; j < entities.Count; j++)
        {
          var entity_j = entities[j];
          if (entity_j.Type == entity_i.Type) continue;

          var dx = entity_i.PosX - entity_j.PosX;
          var dy = entity_i.PosY - entity_j.PosY;
          if (MathF.Sqrt(dx * dx + dy * dy) <= Entity.Size)
          {
            if (entity_i.IsDefeatedBy(entity_j.Type))
            {
              //entity_i.IsAlive = false;
              entity_i.Type = entity_j.Type;
              entities[i] = entity_i;
              break;
            }
            else
            {
              //entity_j.IsAlive = false;
              entity_j.Type = entity_i.Type;
              entities[j] = entity_j;
            }
          }
        }
      }

      // Elimina entità morte
      {
        entities.RemoveAll((x) => !x.IsAlive);
      }

      for (var i = 0; i < entities.Count; i++)
      {
        Color color;
        switch (entities[i].Type)
        {
          case EntityType.Rock: color = Color.Red; break;
          case EntityType.Paper: color = Color.Green; break;
          case EntityType.Scissor: color = Color.Blue; break;
          default: color = Color.LightGray; break;
        }
        Raylib.DrawCircle((int)entities[i].PosX, (int)entities[i].PosY, Entity.Size / scaledpi.X, color);
      }

      Raylib.EndDrawing();
    }

    Raylib.CloseWindow();
  }
}