using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;
using JogoBatalha.Round;

var play = new Player("Adamastor");
var ini = new Enemy();

Round.Battle(play, EnumAction.HeavyAttack, ini);