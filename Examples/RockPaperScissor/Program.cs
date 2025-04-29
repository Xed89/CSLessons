using Raylib_cs;

class RockPaperScissor
{
  public static void Main(string[] args)
  {
    var LarghezzaFinestra = 800;
    var AltezzaFinestra = 800;
    Raylib.InitWindow(LarghezzaFinestra, AltezzaFinestra, "Rock Paper Scissor");
    Raylib.SetTargetFPS(60);

    // Inizializza lo stato del gioco
    var entities = CreateEntities(LarghezzaFinestra, AltezzaFinestra);

    while (!Raylib.WindowShouldClose())
    {
      // Leggi la durata del frame, in secondi
      // Normalmente questo dato, facendo 60 frame al secondo, è 1/60 di secondo, cioè 0.016666... secondi.
      var deltaTime = Raylib.GetFrameTime();

      // Aggiorna lo stato del gioco
      AggiornaPosizioni(entities, deltaTime, LarghezzaFinestra, AltezzaFinestra);
      VerificaCollisioni(entities);

      // Disegna
      Raylib.BeginDrawing();
      Raylib.ClearBackground(Color.White);
      DisegnaEntita(entities);
      // Disegna gli FPS
      float fps = 1 / Raylib.GetFrameTime();
      Raylib.DrawText("FPS: " + fps.ToString("00.0"), 5, 5, 20, Color.Black);
      Raylib.EndDrawing();
    }

    Raylib.CloseWindow();
  }

  enum EntityType
  {
    Rock,
    Paper,
    Scissor
  }

  struct Entity
  {
    public const float Size = 30;
    public EntityType Tipo;
    public float PosX, PosY;
    public float VelX, VelY;

    public bool IsDefeatedBy(EntityType tipoAttaccante)
    {
      if (Tipo == EntityType.Rock)
      {
        return tipoAttaccante == EntityType.Paper;
      }
      else if (Tipo == EntityType.Paper)
      {
        return tipoAttaccante == EntityType.Scissor;
      }
      else if (Tipo == EntityType.Scissor)
      {
        return tipoAttaccante == EntityType.Rock;
      }
      else
      {
        // Questo non dovrebbe mai accadere
        return false;
      }
    }
  }

  static List<Entity> CreateEntities(int larghezzaFinestra, int altezzaFinestra)
  {
    var listaEntita = new List<Entity>();
    var tuttiITipi = new[] { EntityType.Rock, EntityType.Paper, EntityType.Scissor };
    for (var iTipo = 0; iTipo < tuttiITipi.Length; iTipo++)
    {
      for (var i = 0; i < 30; i++)
      {
        var entita = new Entity();
        entita.Tipo = tuttiITipi[iTipo];
        entita.PosX = GeneraNumeroCasuale(10, larghezzaFinestra * 20);
        entita.PosY = GeneraNumeroCasuale(10, altezzaFinestra * 20);

        // Genera un angolo casuale da 0 a 2π
        var velAngle = GeneraNumeroCasuale(0, 2 * MathF.PI);
        // Ricava la componente orizzontale e quella verticale
        var velAngleX = MathF.Cos(velAngle);
        var velAngleY = MathF.Sin(velAngle);
        // Ricava le componenti x e y del vettore velocità dall'angolo e dalla sua lunghezza
        var vel = 100;
        entita.VelX = velAngleX * vel;
        entita.VelY = velAngleY * vel;

        // Aggiungi alla lista delle entità generate
        listaEntita.Add(entita);
      }
    }
    return listaEntita;
  }

  static void AggiornaPosizioni(List<Entity> entities, float deltaTime, int windowWidth, int windowHeight)
  {
    for (var i = 0; i < entities.Count; i++)
    {
      // Copia localmente l'entità leggendola dalla posizione i della lista
      var entity = entities[i];

      // Aggiorna la posizione in base alla velocità, nelle due componenti x e y
      // Qui usiamo la legge della fisica del moto lineare uniforme: 
      // S = V*t  
      // Spazio = Velocità * Tempo
      entity.PosX += entity.VelX * deltaTime;
      entity.PosY += entity.VelY * deltaTime;

      // Se esce dai bordi, riportalo dentro e inverti la direzione della velocità
      // Questa verifica viene fatta per i bordi sinistri e destri con la coordinata x, e sopra e sotto con y
      // Sinistro - Destro rispetto a PosX e VelX usando 0 e windowWidth come limiti
      if (entity.PosX < 0) { entity.PosX = -entity.PosX; entity.VelX = -entity.VelX; }
      if (entity.PosX >= windowWidth) { entity.PosX = 2 * windowWidth - entity.PosX; entity.VelX = -entity.VelX; }

      // Sopra - Sotto rispetto a PosY e VelY usando 0 e windowHeight come limiti
      if (entity.PosY < 0) { entity.PosY = -entity.PosY; entity.VelY = -entity.VelY; }
      if (entity.PosY >= windowHeight) { entity.PosY = 2 * windowHeight - entity.PosY; entity.VelY = -entity.VelY; }

      // Sovrascrivi lo stato di questa entità nella lista con quello appena aggiornato
      entities[i] = entity;
    }
  }

  static void VerificaCollisioni(List<Entity> entities)
  {
    // Doppio ciclo for per confrontare ogni unità 'i' con tutte le 'j' che la seguono nella lista 'entities'
    for (var i = 0; i < entities.Count; i++)
    {
      var entity_i = entities[i];

      // Nota: j parte da i + 1
      for (var j = i + 1; j < entities.Count; j++)
      {
        var entity_j = entities[j];

        // Entità dello stesso tipo non si influenzano tra loro
        if (entity_j.Tipo == entity_i.Tipo) continue;

        // Con il teorema di pitagora calcola la distanza tra le due posizioni delle entità
        var dx = entity_i.PosX - entity_j.PosX;
        var dy = entity_i.PosY - entity_j.PosY;
        var distance_i_j = MathF.Sqrt(dx * dx + dy * dy);

        if (distance_i_j <= Entity.Size)
        {
          if (entity_i.IsDefeatedBy(entity_j.Tipo))
          {
            // i viene sconfitto e diventa come j
            entity_i.Tipo = entity_j.Tipo;
            entities[i] = entity_i;
          }
          else
          {
            // j viene sconfitto e diventa come i
            entity_j.Tipo = entity_i.Tipo;
            entities[j] = entity_j;
          }
        }
      }
    }
  }

  static void DisegnaEntita(List<Entity> entities)
  {
    var scaledpi = Raylib.GetWindowScaleDPI();
    for (var i = 0; i < entities.Count; i++)
    {
      var entity = entities[i];

      // Determina il colore in base al tipo
      Color color;
      if (entity.Tipo == EntityType.Rock)
      {
        color = Color.Red;
      }
      else if (entity.Tipo == EntityType.Paper)
      {
        color = Color.Green;
      }
      else if (entity.Tipo == EntityType.Scissor)
      {
        color = Color.Blue;
      }
      else
      {
        color = Color.Gray;
      }

      Raylib.DrawCircle((int)entity.PosX, (int)entity.PosY, Entity.Size / scaledpi.X, color);
    }
  }

  static float GeneraNumeroCasuale(float min, float max)
  {
    float random_0_1 = (float)Random.Shared.NextSingle();
    return min + random_0_1 * (max - min);
  }
}