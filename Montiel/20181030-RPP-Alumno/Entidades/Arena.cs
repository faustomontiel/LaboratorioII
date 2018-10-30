using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Arena
  {
    
    public int espacioDisponible;
    public  string nombre;
    List<RobotDeCombate> robotsDeCombate;
    List<RobotSirviente> robotsSirviente;

    private Arena()
    {
      this.robotsDeCombate = new List<RobotDeCombate>();
      this.robotsSirviente = new List<RobotSirviente>();   
    }
    public Arena(string nombre, int espacio):this()
    {
      this.nombre = nombre;
      this.espacioDisponible = espacio;
    }

    public string Combate(RobotDeCombate combatiente)
    {
     
        if(this.robotsDeCombate.ElementAt(0).Energia>0)
        {
             
        }

    }
    
    public static bool operator +(Arena arena, Robot robot)
    {
      bool salida = false;

      if (arena != robot)
      {
        if (robot is RobotDeCombate)
        {
          arena.robotsDeCombate.Add((RobotDeCombate)robot);
          salida = true;
        }
        else if(robot is RobotSirviente)
        {
          arena.robotsSirviente.Add((RobotSirviente)robot);
          salida = true;
        }

      }
      return salida;
    }
    public static bool operator -(Arena arena,Robot robot)
    {
      bool salida = false;
      if(arena == robot)
      {
        if (robot is RobotDeCombate)
        {
          arena.robotsDeCombate.Remove((RobotDeCombate)robot);
          salida = true;
        }
        else if (robot is RobotSirviente)
        {
          arena.robotsSirviente.Remove((RobotSirviente)robot);
          salida = true;
        }

      }
      return salida;
    }
    
    public static bool operator ==(Arena arena, Robot robot)
    {
      return (!ReferenceEquals(robot, null) && arena.robotsDeCombate.Contains(robot) || arena.robotsSirviente.Contains(robot));

    }
    public static bool operator !=(Arena arena, Robot robot)
    {
      return !(arena == robot);

    }




  }
}
