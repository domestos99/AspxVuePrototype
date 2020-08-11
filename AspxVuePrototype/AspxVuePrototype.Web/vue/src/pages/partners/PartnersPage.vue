<template>
  <div id="PartnersPage">

    <div class="row">
      <div class="col-sm-12">
        Error: {{ error }}
        <br>

        Name: {{searchQ}}

        <br>


        <div class="form-horizontal">

          <div class="panel-group">

            <div class="panel panel-default">
              <div class="panel-body pb-0">
                <div class="row">

                  <div class="col-sm-6">
                    <div class="form-group">
                      <label for="inputSearchQ" class="col-sm-2 control-label">Název</label>
                      <div class="col-sm-10">
                        <input id="inputSearchQ" type="text" class="form-control"
                               placeholder="Název..."
                               v-model="searchQ">
                      </div>

                    </div>


                  </div>

                </div>
              </div>
            </div>


            <div class="box box-default">
              <div class="box-body">
                <div class="table-responsive">

                  <table class="table table-striped table-condensed table-bordered">
                    <thead>
                    <tr>
                      <th>
                        <a href="javascript:;" v-on:click="orderColumn('Id')">ID
                          &nbsp;<span
                              v-bind:class="[order.orderAsc ? 'fa fa-caret-up' : 'fa fa-caret-down', order.orderBy === 'Id' ? 'visible' : 'd-none']"></span>
                        </a>
                      </th>
                      <th>
                        <a href="javascript:;" v-on:click="orderColumn('Name')">Name
                          &nbsp;<span
                              v-bind:class="[order.orderAsc ? 'fa fa-caret-up' : 'fa fa-caret-down', order.orderBy === 'Name' ? 'visible' : 'd-none']"></span>
                        </a>
                      </th>
                      <th>street</th>
                      <th>city</th>
                      <th>zip</th>
                      <th>country</th>
                      <th>note</th>
                      <th>active</th>
                    </tr>
                    </thead>
                    <tbody>
                    <tr v-for="(p, i) in partnersData" v-bind:key="i">
                      <td>{{ p.Id }}</td>
                      <td>{{ p.Name }}</td>
                      <td>{{ p.Street }}</td>
                      <td>{{ p.City }}</td>
                      <td>{{ p.Zip }}</td>
                      <td>{{ p.Country }}</td>
                      <td>{{ p.Note }}</td>
                      <td>{{ p.Active }}</td>
                    </tr>
                    </tbody>
                  </table>

                </div>
                <div class="row">
                  <div class="col-sm-6">
                    <b-pagination
                        v-model="paginator.page"
                        :total-rows="total"
                        :per-page="paginator.pageSize"
                        :limit="7"
                        last-number
                        aria-controls="my-table"
                        v-on:change="loadData"
                    ></b-pagination>
                  </div>
                  <div class="col-sm-1 col-sm-offset-5 form-group-sm">
                    <b-form-select class="form-control" v-model="paginator.pageSize"
                                   :options="[5, 10, 20,50,100,500,1000]"
                                   v-on:change="loadData"></b-form-select>
                  </div>
                </div>


              </div>
              <div class="overlay">
                <b-spinner v-if="loading" variant="primary" label="Loading..."></b-spinner>
              </div>
            </div>

          </div>


        </div>

      </div>

    </div>
  </div>

</template>

<script>
import PartnerService from "@/services/partner.service";

export default {
  name: 'PartnersPage',
  data() {
    return {
      loading: false,
      partnersData: [],
      error: null,
      searchQ: '',
      order: {
        orderBy: 'Id',
        orderAsc: true
      },
      showModal: false,
      paginator: {
        page: 1,
        pageSize: 5
      },
      total: 100,
    }
  },
  mounted() {
    this.loadData();
  },
  methods: {
    loadData() {
      const self = this;
      self.loading = true;
      self.error = null;

      new PartnerService().getPartners(this.paginator, this.order, function (data) {
        self.loading = false;
        if (data.Success) {
          self.partnersData = data.Data;
          self.paginator.page = 1;
          self.total = self.partnersData.lenght;
        } else {
          self.error = data.Message;
          console.log(data.Message);
        }
      });
    },
    orderColumn(key) {
      this.order.orderAsc = !this.orderAsc;
      this.order.orderBy = key;
      this.loadData();
    }
  }
}


</script>
