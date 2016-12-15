##### Especialização em Arquitetura de Software Distribuído
##### Disciplina: Arquitetura Orientada à Serviços (SOA)
##### Trabalho Final: Barramento de Serviços
##### Professor: Biharck Araújo
##### Alunos: Pedro Amaral (68072) e Vinícius Amaral (67652)

<br/>

<p align="center">Trabalho final da disciplina de Arquitetura Orientada a Serviços</p><br/>

Observações:

- No SOAP UI há diferentes responses cadastrados para os serviços legados de crédito, possibilitando que diferentes resultados de score sejam experimentados ao se chamar o serviço repetidas vezes.
- Criamos no SOAP UI projetos que chamam os serviços expostos pelos proxies CreditoGeralServiceSecurity e PessoaSecurity publicados no OSB. Esses projetos possibilitam testar o fluxo criando tanto o request quanto o response pelo SOAP UI.
- Colocamos chamadas de Log dentro de CreditoGeralService para que seja entendido mais facilmente o fluxo de execução após cada tomada de decisão.
- Foram utilizados Mocks do SOAP UI para todas as operações. Implementamos o conteúdo do vídeo para o cadastro de pessoas no Mule, mas não utilizamos a ferramenta pelo OSB.
- No serviço CreditoGeralService, interpretamos a lógica para o cálculo do score e orquestração dos serviços conforme abaixo:

```javascript
if (valorCreditoExterno > 400)
	return 200;

if (quantidadeRestricoesInternas <= 3)
{
	if (valorCreditoInterno < 200)
		return 500;
	else if (indicadorWhiteList)
		return 900;
}
else
	return 0;

return 1000;
```
