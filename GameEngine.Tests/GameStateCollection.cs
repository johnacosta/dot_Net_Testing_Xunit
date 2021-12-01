using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GameEngine.Tests
{
    [CollectionDefinition("GameState Collection")]
    public class GameStateCollection : ICollectionFixture<GameStateFixture>
    {
    }
}
