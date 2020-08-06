<template>

  <div class="dataTables_paginate paging_simple_numbers" id="example2_paginate">
    <ul class="pagination">

<!--      First-->
      <li class="paginate_button page-item previous" id="example2_first">
        <a href="javascript:;" aria-controls="example2" data-dt-idx="0" tabindex="0" class="page-link"
        v-on:click="goFirst">««</a>
      </li>

<!--Previous-->
      <li class="paginate_button page-item previous" id="example2_previous">
        <a href="javascript:;" aria-controls="example2" data-dt-idx="0" tabindex="0" class="page-link"
           v-on:click="goForward">«</a>
      </li>

<!--      Pages-->
      <li class="paginate_button page-item"
      v-for="(a, i) in pages" v-bind:key="i"
      >
        <a href="" aria-controls="example2" data-dt-idx="1" tabindex="0" class="page-link"
        v-on:click="selectPage(a.number)">{{a.text}}</a>
     </li>
<!--      End pages-->


<!--      Next-->
      <li class="paginate_button page-item next" id="example2_next">
        <a href="javascript:;" aria-controls="example2" data-dt-idx="7" tabindex="0" class="page-link"
        v-on:click="goForward"
        >»</a>
      </li>

<!--      Last-->
      <li class="paginate_button page-item next" id="example2_last">
        <a href="javascript:;" aria-controls="example2" data-dt-idx="7" tabindex="0" class="page-link"
        v-on:click="goLast"
        >»»</a>
      </li>


    </ul>
  </div>


</template>
<script>
const $ = require('jquery');

export default {

  name: 'Pagination',
  data() {
    return {
      currentPage: 1,
      totalCount: 100,
      pageSize: 5,
      maxPages: 5,
      pagesCount: 25,
      directions: true,
      boundary: true,
      text: {
        first: '««',
        last: '»»',
        back: '«',
        forward: '»'
      }
    }
  },
  methods: {
    goFirst(){
      this.currentPage = 1;
    },
    goLast(){
      this.currentPage = this.pagesCount;
    },
    selectPage(page){
      this.currentPage = page;
    },
    getStartPage(){
      var maxPages = 5; // +ko.unwrap(self.maxPages);

      return ((Math.ceil(this.currentPage/ maxPages) - 1) * maxPages) + 1;

    },
    getLastPage(startPage){
      var maxPages = 5; // +ko.unwrap(self.maxPages);
      return Math.min(startPage + maxPages - 1, this.pagesCount);
    },
    goBack(){

    },
    goForward()
    {

    }
    // Page(number, text, isActive){
    //   this.number = number;
    //   this.text = text || number;
    //   this.isActive = !!isActive;
    // }

  },
  computed: {
    pages: function (){
      let pages = [];

      let startPage = this.getStartPage();
      let endPage = this.getLastPage(startPage);

      for (var pageNumber = startPage; pageNumber <= endPage; pageNumber++) {
        pages.push(
            {
              number: pageNumber,
              text: pageNumber,
              isActive: pageNumber === this.currentPage
            });
      }

      if (startPage > 1) {
        pages.unshift(
            {
              number: startPage - 1,
              text: '...',
              isActive: false
            });
      }

      if (endPage < this.pagesCount) {
        pages.push({
          number: endPage + 1,
          text: '...',
          isActive: false
        });
      }

      return pages;


    }
  }
}

</script>
