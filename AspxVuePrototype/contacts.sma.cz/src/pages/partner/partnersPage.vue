<template>
  <div>

    <a class="btn btn-primary pull-right" id="btnInsertNew" href="javascript:;" v-on:click="openNewModal">
      <i class="fa fa-plus-circle"></i>&nbsp;
      Nová položka
    </a>

    <b-modal id="newPartnerModal" title="Nový partner">
      <partnerNewModal></partnerNewModal>
    </b-modal>


    <div class="form-horizontal">

      <div class="card">
        <div class="card-body pb-0">
          <div class="row">
            <div class="col-sm-6">
              <div class="form-group">
                <label for="inputSearchQ" class="col-sm-2 control-label">Název</label>
                <div class="col-sm-10">
                  <input id="inputSearchQ" type="text" class="form-control" placeholder="Název..."
                         v-model="q" v-on:keypress="inputOnEnter">
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>


      <div class="card">
        <div class="card-body">
          <div class="table-responsive">
            <table class="table table-striped table-hover table-condensed">
              <thead>
              <tr>
                <th>
                  <a href="javascript:;" v-on:click="orderColumn('Name')">Jméno
                    &nbsp;<span
                        v-bind:class="[order.orderAsc ? 'fa fa-caret-up' : 'fa fa-caret-down', order.orderBy === 'Name' ? 'visible' : 'd-none']"></span>
                  </a>
                </th>
                <th>
                  <a href="javascript:;" v-on:click="orderColumn('Street')">Ulice
                    &nbsp;<span
                        v-bind:class="[order.orderAsc ? 'fa fa-caret-up' : 'fa fa-caret-down', order.orderBy === 'Street' ? 'visible' : 'd-none']"></span>
                  </a>
                </th>
              </tr>
              </thead>
              <tbody>
              <tr v-for="(per, i) in partners" v-bind:key="i">
                <td>{{ per.Name }}</td>
                <td>{{ per.Street }}</td>
              </tr>
              </tbody>

            </table>
          </div>
          <div class="row">

            <div class="col-sm-6">
              <b-pagination
                  v-model="pagination.page"
                  :total-rows="pagination.total"
                  :per-page="pagination.pageSize"
                  first-number
                  last-number
                  first-text="««"
                  prev-text="«"
                  next-text="»"
                  last-text="»»"
              ></b-pagination>
            </div>

            <div class="col-sm-1 col-sm-offset-5 form-group-sm">
              <b-form-select v-model="pagination.pageSize" :options="[20, 50, 100, 200, 500, 1000]"
                             v-on:change="search"></b-form-select>
            </div>

          </div>

        </div>
      </div>

    </div>


  </div>
</template>

<script>

import $ from 'jquery';
import partnerNewModal from "./partnerNewModal";

export default {
  name: 'partners',
  components: {
    partnerNewModal
  },
  data() {
    return {
      partners: [],

      pagination: {
        page: 1,
        total: 0,
        pageSize: 20
      },
      order: {
        orderBy: 'Name',
        orderAsc: true
      },
      q: ''

    };
  },
  mounted() { // = init
    this.search();
  },
  methods: {
    search() {
      const self = this;
      $.post('/Handlers/PartnerHandler.ashx?action=search',
          {
            q: self.q,

            page: self.pagination.page,
            pageSize: self.pagination.pageSize,
            OrderByProperty: self.order.orderBy,
            OrderByAsc: self.order.orderAsc,
          },
          function (data) {
            if (data.Success) {
                self.partners = data.Data;
                self.pagination.total = self.partners.length;
            } else {
              console.log(data.Message);
            }
          }
      );
    },
    orderColumn(key) {
      this.order.orderAsc = !this.order.orderAsc;
      this.order.orderBy = key;
      this.search();
    },
    inputOnEnter(event) {
      if (event.keyCode === 13) {
        this.search();
        return false;
      } else {
        return true;
      }
    },
    openNewModal(){
      this.$bvModal.show('newPartnerModal');
    }
  }
}

</script>

<style scoped>
.dummy {
}
</style>
