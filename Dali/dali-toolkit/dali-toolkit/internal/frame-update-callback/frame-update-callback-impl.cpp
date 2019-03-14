/*
 * Copyright 2017 by Samsung Electronics, Inc.,
 *
 * This software is the confidential and proprietary information
 * of Samsung Electronics, Inc. ("Confidential Information").  You
 * shall not disclose such Confidential Information and shall use
 * it only in accordance with the terms of the license agreement
 * you entered into with Samsung.
 *
 */

// CLASS HEADER
#include <dali-toolkit/internal/frame-update-callback/frame-update-callback-impl.h>

// EXTERNAL INCLUDES
#include <dali-toolkit/dali-toolkit.h>
#include <dali/devel-api/common/stage-devel.h>

// INTERNAL INCLUDES

using namespace Dali;

namespace Dali
{

namespace ToolKit
{

namespace Internal
{

FrameUpdateCallback::FrameUpdateCallback()
  : mFrameCallback()
{
  mStage = Stage::GetCurrent();
}

FrameUpdateCallback::~FrameUpdateCallback()
{
  DevelStage::RemoveFrameCallback( mStage, mFrameCallback );
  mFrameCallback.RemoveFrameUpdateCallback();
}

bool FrameUpdateCallback::GetPosition( unsigned int id, Vector3& position ) const
{
  return mFrameCallback.GetPosition( id, position );
}

bool FrameUpdateCallback::SetPosition( unsigned int id, const Vector3& position )
{
  return mFrameCallback.SetPosition( id, position );
}

bool FrameUpdateCallback::BakePosition( unsigned int id, const Vector3& position )
{
  return mFrameCallback.BakePosition( id, position );
}

bool FrameUpdateCallback::GetSize( uint32_t id, Vector3& size ) const
{
  return mFrameCallback.GetSize( id, size );
}

bool FrameUpdateCallback::SetSize( uint32_t id, const Vector3& size )
{
  return mFrameCallback.SetSize( id, size );
}

bool FrameUpdateCallback::BakeSize( uint32_t id, const Vector3& size )
{
  return mFrameCallback.BakeSize( id, size );
}

bool FrameUpdateCallback::GetScale( unsigned int id, Vector3& scale ) const
{
  return mFrameCallback.GetScale( id, scale );
}

bool FrameUpdateCallback::SetScale( unsigned int id, const Dali::Vector3& scale )
{
  return mFrameCallback.SetScale( id, scale );
}

bool FrameUpdateCallback::BakeScale( unsigned int id, const Vector3& scale )
{
	return mFrameCallback.BakeScale( id, scale );
}

bool FrameUpdateCallback::GetColor( unsigned int id, Vector4& color ) const
{
  return mFrameCallback.GetColor( id, color );
}

bool FrameUpdateCallback::SetColor( unsigned int id, const Dali::Vector4& color )
{
  return mFrameCallback.SetColor( id, color );
}

bool FrameUpdateCallback::BakeColor( unsigned int id, const Vector4& color ) const
{
  return mFrameCallback.BakeColor( id, color );
}

IntrusivePtr<FrameUpdateCallback> FrameUpdateCallback::New()
{
  IntrusivePtr<FrameUpdateCallback> handle( new FrameUpdateCallback() );
  return handle;
}

void FrameUpdateCallback::AddCallback(FrameCallbackFunction frameCallback)
{
  mFrameCallback.SetUpdateCallback(frameCallback);
  DevelStage::AddFrameCallback( mStage, mFrameCallback, mStage.GetRootLayer() );
}

void FrameUpdateCallback::RemoveCallback()
{
  DevelStage::RemoveFrameCallback( mStage, mFrameCallback );
  mFrameCallback.RemoveFrameUpdateCallback();
}
} // namespace Internal
} // namespace ToolKit
} // namespace DaliExt
