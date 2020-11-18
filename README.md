# mws.mc
Modular Web System by Micke CORNIER

Systeme de sites web modulaire en .Net Core MVC.

----------
Notes
----------

Les modules implémentent des composents pouvant être integrer dans des pages définies par l'administrateur du site déployé.
Les modules sont dans ~/Modules
Chaques modules gère lui même ses données.
Au démarage du module, le coeur donne en données de démarrage "Type de connexion BDD", "ConnexionString", "Version du coeur" (et plus à l'avenir)

Le nommage des modules MWS.MC est le suivant :
  mws.[devname].[modulename] un composant bar créé par foo sera nommé mws.foo.bar


----------
Licence
----------

Projet mws.core en sources fermées.
Modules selon les besoins


----------
Opbjectifs
----------

1 - Coeur MWS.MC [mws.mc.core]
    Implémenter le moteur MWS avec 
          - Systeme de connexion Identity (P1)
          - Rôles (P3)
          - Gestion de modules (P1 - 50%)
          - Gestion des composants (P1)
          - Gestion de pages (P2)
          - Gestion de navigation (P3)
          - Gestion du paramétrage des modules (P2 - 10%)

2 - Projet de module [mws.mc.module]
    Definition des modules
          - Interface module V1 (100%)
     
3 - Module D3M0 [mws.mc.demo]
    Module de démonstration proposant un composant basique 
          - Composant de démonstration (P1 - 80%)

- (P4 et +) -

1 - Coeur MWS.MC [mws.mc.core]
    Implémenter le moteur MWS avec 
          - Gestion du type de rendu des composants : Empty, Card, Modal, Page (P5)

	        Empty           Card               Modal                Page
                                                              _______________________
			Title           +----------+       +-------------+      |Site_Menu_________Log|
			                | Title    |       | Title      X|			"""""""""""""""""""""""                         
			*A              +----------+       +-------------+		  | 	|            |    |
			AaaBbb          | *A       |       | *A          |      | 	| Title      |    |
			                | AaaBbb   |       | AaaBbb      |      |	  |            |    |
			*B              |          |       |             |      | 	| *A         |    |
			AaaBbb          | *B       |       | *B          |      | 	| AaaBbb     |    |
			                | AaaBbb   |       | AaaBbb      |      |	  |            |    |
                      +----------+       +-------------+      | 	| *B         |    |
                                         |      [Close]|      |	  | AaaBbb     |    |
                                         +-------------+      |	  |____________|    |
																                              |	                    |

4 - Module Articles [mws.mc.article]
    Module d'affichage d'articles
          - Base de données mws.mc.article*
          - Composant d'affichage d'un article (P5)
          - Composant d'affichage des articles en vue tuiles infinies (P5)
          - Composant d'affichage des articles en vue table (P6)
          - Composant de recherche d'articles (P7)
          - Gestion des Rôles (P8)
          - Systeme de communication inter composants (et donc intermodules) (p10)
          
5 - Module de Gestion d'Articles [mws.mc.articlemanager]
          - Composant de saisie d'article (P4)
          - Composant CRUD article (P7)
          - Gestion des Rôles (P8)

6 - Module de Commentaires d'Articles [mws.mc.articlecomments]
          - Composant d'affichage de commentaires (pour un artcicle) (p9)
          - Composant de gestion des commentaires (p9)

7- Module de pièces jointes [mws.mc.attachment]
          - Composant d'import de pièeces jointes (p9)
          - Composant d'affichage de pièce jointes (p9)

------------------------------------------------------------------------------------
Ensuite, identification des besoins et création de nouveaux modules

Pistes : 
  - Modules de gestion d'élevage canin :
      - Module de gestion des chiens (saisie de fiches chien (simples), généalogie chiens, fiches propriétaires
      - Module d'articles chiens (génère un article [mws.mc.article] généré avec la fiche chien)
