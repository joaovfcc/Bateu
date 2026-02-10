# 🎯 Bateu - Clean Architecture & Rich Domains Showcase

> **Nota:** Este repositório é um projeto de **estudo**. O objetivo principal é demonstrar a implementação de padrões arquiteturais modernos, modelagem de domínios ricos e boas práticas em .NET, utilizando um cenário de conciliação financeira como contexto de negócio.

---

## 🏗️ Sobre a Arquitetura

O projeto foi desenhado seguindo os princípios da **Clean Architecture**, mas com uma abordagem **leve e pragmática**, evitando over-engineering desnecessário. A prioridade foi manter o acoplamento baixo e a testabilidade alta.

### 💎 Destaques Técnicos

* **Domínios Ricos (Rich Domain Models):**
    * As regras de negócio vivem dentro das entidades no projeto `Bateu.Domain`, e não em "Service Classes" anêmicas.
    * Validações de invariantes são feitas no momento da construção do objeto.
* **Separação de Responsabilidades:**
    * A camada `Bateu.API` não conhece regras de negócio, apenas orquestra a entrada/saída.
    * A camada `Bateu.Infrastructure` é a única que conhece detalhes como banco de dados ou sistemas de arquivos.
* **Processamento Assíncrono:**
    * Implementação de padrão **Producer-Consumer** utilizando `System.Threading.Channels` para processamento de arquivos pesados sem bloquear a thread principal da API.

---

## 📐 Estrutura da Solução

```text
Bateu/
├── 📂 Bateu.Domain          # O "Coração". Entidades, Value Objects e Interfaces. (Zero dependências externas)
├── 📂 Bateu.Application     # Casos de uso, DTOs e Interfaces de Serviços.
├── 📂 Bateu.Infrastructure  # Implementação de DB (EF Core), File Parsers e Background Jobs.
└── 📂 Bateu.API             # Entry point, Controllers e Injeção de Dependência.
