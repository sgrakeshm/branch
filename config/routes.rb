BranchApp::Application.routes.draw do

  # Core
  root :to => 'home#index'
  get '/welcome' => 'home#welcome', as: :home_welcome

  # Account
  get '/user/signin' => 'user#signin', as: :user_signin
  get '/user/register' => 'user#register', as: :user_register
  get '/user/:username' => 'user#view', as: :user_view

  # Search
  get '/search/:focus/' => 'search#search', as: :search_query, defaults: { focus: 'all' }

  # Halo 4
  get '/halo4/' => 'halo4/home#index', as: :halo4_home
  get '/halo4/servicerecord/:gamertag/' => 'halo4/service_record#index', as: :halo4_servicerecord
end
