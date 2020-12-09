using System;
namespace WizardNinjaSamurai.Models
{
    class Samurai : Human
    {
    
        public Samurai ( string name ) : base ( name )
        {
            SetHealth( 200 ); 
        }
        public override int Attack(Human target)
        {
            if( target.Health < 50 )
            {
                target.SetHealth( 0 );
                Console.WriteLine( $"{ target.Name } has been eliminated" );
                
            }
            Console.WriteLine( $"{ Name } failed to kill { target.Name }" );
            return target.Health;
        }
        public void Meditate()
        {
            SetHealth( 200 ); 
            Console.WriteLine( $"{ Name } will meditate. { Health } is the restored Hp." );
        }
    }
}
