
## Vuforia x Blynk project

Este projeto se trata de uma experiência integrando recursos da plataforma [Blynk](https://blynk.io/)  com o kit de desenvolvimento de software de realidade aumentada para dispositivos móveis [Vuforia](https://developer.vuforia.com/), utilizando como engine, a [Unity](https://unity.com/pt).

### Descrição do projeto

A ideia do projeto é visualizar informações de microcontroladores no ambiente de realidade aumentada, onde apontando a câmera para um microcontrolador aparecera um painel com informações e estados de recursos conectados a ele. Para mostrar essas informações, foi utilizado a API da plataforma Blynk.

#### Plataforma Blynk e Microcontroladores

Para a experiência foi utilizado parte do projeto [MMM-BlynkCloud](https://github.com/wTornich/MMM-BlynkCloud) que envolve o microcontrolador Esp8266. A ele está conectado uma fita de LED endereçável, um LED comum e um sensor de luminosidade (LDR).

##### [IMAGEM DO CIRCUITO MICROCONTROLADOR]

Do lado da plataforma Blynk está configurado dois botões que ativa de desativa os LEDs e um gráfico que monitora a intensidade de luz capturada pelo LRD. Essa informação somada ao estados dos botões também é possível ser acessada através da API da plataforma, recurso que esse que foi utilizado para mostrar e atualizar as informações no painel 3D.

##### [IMAGEM DA PLATAFORMA BLYNK]

#### Método de detecção de objeto 3D com Vuforia

Entre os métodos disponíveis para *tracking* de um objeto que o Vuforia oferece, foi testado o método onde configura-se um ângulo específico em que se espera que o usuário aponte a câmera e o método de domo 3D, onde o objeto 3D passa por um treinamento de inteligência artificial, calculando vários ângulos de visão possíveis.

- Para configurar os métodos de tracking o Vuforia oferece sua própria ferramenta, o [Vuforia Model Target Generator](https://developer.vuforia.com/downloads/tool).
- O objeto 3D do Esp8266 utilizado está disponível neste [link](https://sketchfab.com/3d-models/esp8266-f7b9d556f9944094a043238350354d62). 
- 
##### [IMAGEM DO FUNCIONAMENTO]


##### [BOTÃO PARA VIZUALIZAR VÍDEO DO FUNCIONAMENTO DO PROJETO]
 
