/* 
             
            4) Você está em uma sala com três interruptores, cada um conectado a
            uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está,
            mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é 
            descobrir qual interruptor controla qual lâmpada.

            Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas,
            qual interruptor controla cada lâmpada?

            Resposta:

            Primeiro mantenho os 3 interruptores desligados e em seguida ligo 1.

            Aguardo 5 minutos, desligo o primeiro que havia ligado e ligo o segundo, dessa forma, prossigo
            para uma das salas, minha chance para acertar qual lampada passa a ser 100% para primeira sala que visitei,
            pois ao chegar em uma da salas, se não estiver acesa, verifico se esta quente, pois a lampada ligada após certo tempo
            gera calor e deve ficar aquecida.

            Com isso, tenho 3 condições:

            1ª - Lampada acesa
            2ª - Lampada quente
            3ª - Lampada desligada (fria)

            # Se a lampada estiver acesa, atribuo a sala ao interruptor ligado.
            # Se a lampada estiver quente, atribo a sala ao interruptor que liguei primeiro e mantive ligado por 5 minutos.
            # Se a lampada estiver apagada (fria), atribuo a sala do interruptor que não liguei.

            Com uma ida vou descobrir a primeira sala.

            Retorno a sala central, desligo o interruptor que mantive ligado e ligo novamente a primeira lampada
            que eu liguei e mantive por 5 minutos.

            Pois dessa forma, ainda sim terei uma lampada que ficará fria e não irei confundir com as lampadas que ja liguei.

            Descobrindo a segunda sala, já 3 é a sala restante que deve corresponder ao último interruptor.



             */