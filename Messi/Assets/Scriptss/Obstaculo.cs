using UnityEngine;

public class Obstaculo : ObjetoMundo
{
    public int danio = 1;


    public override void AlContacto(Jugador jugador)
    {
        jugador.RecibirDano(danio);

        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Jugador jugador = collision.gameObject.GetComponent<Jugador>();
        if (jugador != null)
        {
            AlContacto(jugador);
        }
    }
}
