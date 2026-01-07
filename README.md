# FCG-Contracts

Biblioteca de **contratos de mensageria** utilizada no ecossistema **FCG Games**.  
Este projeto fornece um conjunto de **DTOs e eventos padronizados** para comunicação entre microsserviços, garantindo consistência e interoperabilidade.

---

## Objetivo

- Centralizar a definição de **eventos de domínio** e **contratos de integração**.
- Evitar duplicação de código entre microsserviços.
- Garantir que todos os serviços falem a mesma "linguagem" ao publicar e consumir mensagens.
- Facilitar evolução e versionamento dos contratos.

---

##  Eventos de Domínio

 **Eventos de Usuário**
  - `UserCreatedEvent`
  - `UserDeletedEvent`
  - `UserLoginEvent`
	
 **Eventos de Pagamento**
  - `PaymentCreatedEvent`
  - `PaymentDeletedEvent`
  - `PaymentProcessedEvent`
	
 **Eventos de Games**
  - `GameCreatedEvent`
  - `GameDeletedEvent`
  - `GameUpdatedEvent`

 **Eventos de Biblioteca**
  - `LibraryItemCreatedEvent`
  - `LibraryItemDeletedEvent`
  - `LibraryItemUpdatedEvent`


##  Interfaces

**IDomainEvent**
- Interface base para todos os eventos de domínio.

**IEventPublisher**
- Interface para publicação de eventos.

**IEventStore**
- Interface para armazenamento e recuperação de eventos.

## Implementações

**StoredEvent**
- Implementação concreta de um evento armazenado.

**MongoEventStore**
- Implementação do IEventStore utilizando MongoDB como backend.

**ServiceBusEventPublisher**
- Implementação do IEventPublisher utilizando Azure Service Bus.


## Instalação

Adicione a referência ao pacote no seu projeto .NET:

```bash
dotnet add package FCG.Shared.Contracts
