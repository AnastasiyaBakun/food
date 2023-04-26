/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     26.04.2023 11:54:38                          */
/*==============================================================*/

/*==============================================================*/
/* Table: category                                              */
/*==============================================================*/
create table category
(
   cat_id               tinyint not null  comment '',
   cat_name             varchar(30)  comment '',
   cat_description      varchar(255)  comment '',
   primary key (cat_id)
)
;

/*==============================================================*/
/* Table: food                                                  */
/*==============================================================*/
create table food
(
   fd_id                tinyint not null  comment '',
   fd_amount            int  comment '',
   fd_manufacture_date  date  comment '',
   fd_expiration_date   date  comment '',
   fd_cost              float(10,2)  comment '',
   fd_product_id        tinyint not null  comment '',
   fd_meal_id           tinyint not null  comment '',
   primary key (fd_product_id, fd_meal_id, fd_id)
)
;

/*==============================================================*/
/* Table: meal                                                  */
/*==============================================================*/
create table meal
(
   ml_id                tinyint not null  comment '',
   ml_recipe_id         tinyint not null  comment '',
   ml_name              varchar(50)  comment '',
   ml_description       varchar(255)  comment '',
   primary key (ml_recipe_id, ml_id)
)
;

/*==============================================================*/
/* Table: measure                                               */
/*==============================================================*/
create table measure
(
   ms_id                tinyint not null  comment '',
   ms_long_name         varchar(25)  comment '',
   ms_short_name        varchar(5)  comment '',
   primary key (ms_id)
)
;

/*==============================================================*/
/* Table: product                                               */
/*==============================================================*/
create table product
(
   pr_id                tinyint not null  comment '',
   pr_name              varchar(30)  comment '',
   pr_measure_id        tinyint not null  comment '',
   pr_description       varchar(255)  comment '',
   primary key (pr_id, pr_measure_id)
)
;

/*==============================================================*/
/* Table: 'product/category'                                    */
/*==============================================================*/
create table product_category
(
   cat_id               tinyint not null  comment '',
   pr_id                tinyint not null  comment '',
   primary key (cat_id, pr_id)
)
;

/*==============================================================*/
/* Table: 'product/recipe'                                      */
/*==============================================================*/
create table product_recipe
(
   rp_id                tinyint not null  comment '',
   pr_id                tinyint not null  comment '',
   amount               int not null  comment '',
   primary key (rp_id, pr_id)
)
;

/*==============================================================*/
/* Table: recipe                                                */
/*==============================================================*/
create table recipe
(
   rp_id                tinyint not null  comment '',
   rp_name              varchar(50)  comment '',
   rp_cooking           varchar(255)  comment '',
   primary key (rp_id)
);


/*==============================================================*/
/* Table: shop_list                                             */
/*==============================================================*/
create table shop_list
(
   lst_id               tinyint not null  comment '',
   lst_product_id       tinyint not null  comment '',
   lst_amount           int  comment '',
   lst_date             date  comment '',
   lst_bought           bool  comment '',
   primary key (lst_product_id, lst_id)
);


alter table meal add constraint FK_MEAL_FOOD_MEAL_FOOD foreign key (ml_id)
      references food (fd_meal_id) on delete restrict on update restrict;

alter table product add constraint FK_PRODUCT_PRODUCT_M_MEASURE foreign key (pr_measure_id)
      references measure (ms_id) on delete restrict on update restrict;

alter table product add constraint FK_PRODUCT_PRODUCT_S_SHOP_LIS foreign key (pr_id)
      references shop_list (lst_id) on delete restrict on update restrict;

alter table product_category add constraint FK_PRODUCT__RELATIONS_PRODUCT foreign key (cat_id)
      references product (pr_id) on delete restrict on update restrict;

alter table product_category add constraint FK_PRODUCT__RELATIONS_CATEGORY foreign key (pr_id)
      references category (cat_id) on delete restrict on update restrict;

alter table product_recipe add constraint FK_PRODUCT__RELATIONS_PRODUCT foreign key (rp_id)
      references product (pr_id) on delete restrict on update restrict;

alter table product_recipe add constraint FK_PRODUCT__RELATIONS_RECIPE foreign key (pr_id)
      references recipe (rp_id) on delete restrict on update restrict;

alter table recipe add constraint FK_RECIPE_MEAL_RECI_MEAL foreign key (rp_id)
      references meal (ml_recipe_id) on delete restrict on update restrict;

alter table shop_list add constraint FK_SHOP_LIS_FOOD_SHOP_FOOD foreign key (lst_product_id)
      references food (fd_product_id) on delete restrict on update restrict;

